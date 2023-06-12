using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using STIL.ServiceClient.ConfigurationProviders;
using STIL.ServiceClient.Util.SoapHelper;

[assembly: InternalsVisibleTo("STIL.ServiceClient.Tests")]

namespace STIL.ServiceClient
{
    /// <inheritdoc />
    internal class StilServiceClient : IStilServiceClient
    {
        private const string UrlServiceAffix = "/services";
        private const string Version = "v1";
        private readonly StringBuilder _baseUrlBuilder = new ();
        private readonly X509Certificate2 _clientCertificate;
        private readonly X509Certificate2 _signingCertificate;
        private readonly IRetryPolicyProvider _retryPolicyProvider;
        private HttpClient _stilHttpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="StilServiceClient" /> class.
        /// </summary>
        /// <param name="baseUrl">The baseUrl for the SOAP services, ex. https://et.integrationsplatformen.dk.</param>
        /// <param name="areaAffixUrl">The area affix url, ex. /VEU.</param>
        /// <param name="clientCertificate">The http client certificate.</param>
        /// <param name="signingCertificate">The xml signing certificate.</param>
        internal StilServiceClient(string baseUrl, string areaAffixUrl, X509Certificate2 clientCertificate, X509Certificate2 signingCertificate)
            : this(baseUrl, areaAffixUrl, clientCertificate, signingCertificate, new DefaultRetryPolicyProvider())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StilServiceClient" /> class.
        /// </summary>
        /// <param name="baseUrl">The baseUrl for the SOAP services, ex. https://et.integrationsplatformen.dk.</param>
        /// <param name="areaAffixUrl">The area affix url, ex. /VEU.</param>
        /// <param name="clientCertificate">The http client certificate.</param>
        /// <param name="signingCertificate">The xml signing certificate.</param>
        /// <param name="retryPolicyProvider">The retry policy provider.</param>
        internal StilServiceClient(string baseUrl, string areaAffixUrl, X509Certificate2 clientCertificate, X509Certificate2 signingCertificate, IRetryPolicyProvider retryPolicyProvider)
        {
            _clientCertificate = clientCertificate;
            _signingCertificate = signingCertificate;
            _retryPolicyProvider = retryPolicyProvider;

            var clientHttpHandler = new HttpClientHandler
            {
                ClientCertificates = { _clientCertificate },
            };

            _stilHttpClient = new HttpClient(clientHttpHandler);
            _baseUrlBuilder.Append(baseUrl.TrimEnd('/')).Append(UrlServiceAffix).Append(areaAffixUrl);
        }

        /// <inheritdoc />
        public async Task<TResponse> SendSoapRequest<TRequest, TResponse, TServiceFaultDetailer>(string methodName, TRequest dataRequest, CancellationToken cancellationToken = default)
            where TRequest : class
            where TResponse : class
            where TServiceFaultDetailer : class
        {
            var retryHandler = _retryPolicyProvider.GetRetryPolicy();
            var urlBuilder = _baseUrlBuilder;
            urlBuilder.Append($"/{methodName}/{Version}");
            var stilRequest = new SignedStilSoapMessage<TRequest>(dataRequest);

            var response = await retryHandler.ExecuteAsync(async () =>
            {
                var signedRequest = stilRequest.GetSignedXml(_signingCertificate);
                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    request.Method = HttpMethod.Post;
                    request.Content = new StringContent(signedRequest, Encoding.UTF8, "application/soap+xml");
                    request.RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute);
                    return await _stilHttpClient
                               .SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                               .ConfigureAwait(false)
                           ?? throw new InvalidOperationException(
                               $"{nameof(_stilHttpClient.SendAsync)} returned null for response type: {typeof(TResponse).Name}.");
                }
            });

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    return await ReadObjectResponseAsync<TResponse>(response).ConfigureAwait(false)
                           ?? throw new FaultException(
                               $"{nameof(ReadObjectResponseAsync)} returned null for response type: {typeof(TResponse).Name}.");
                }

                throw await GetFaultException<TServiceFaultDetailer>(response);
            }
            finally
            {
                response.Dispose();
            }
        }

        /// <summary>
        /// sets the instance of the <see cref="HttpClient" /> class.
        /// Used for test purposes.
        /// </summary>
        /// <param name="httpClientHandler">The http client.</param>
        internal void SetHttpClient(HttpClientHandler httpClientHandler)
        {
            _stilHttpClient = new HttpClient(httpClientHandler);
        }

        /// <summary>
        /// Deserialize response from xml.
        /// </summary>
        /// <typeparam name="T">The return type.</typeparam>
        /// <param name="response">The response.</param>
        /// <returns>The deserialized response.</returns>
        /// <exception cref="InvalidOperationException">Thrown when document cannot be deserialized.</exception>
        private static async Task<T?> ReadObjectResponseAsync<T>(
            HttpResponseMessage? response)
            where T : class
        {
            if (response?.Content == null)
            {
                return default;
            }

            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            XDocument document = XDocument.Parse(responseText);
            var responseTypeName = typeof(T)
                .GetCustomAttributes(typeof(XmlRootAttribute), true)
                .OfType<XmlRootAttribute>()
                .Select(attr => attr.ElementName)
                .FirstOrDefault() ?? typeof(T).Name;

            XElement? body = document.Root?.Descendants().FirstOrDefault(d => d.Name.LocalName == responseTypeName);
            if (body == null)
            {
                throw new InvalidOperationException(
                    $"The response type: {typeof(T).Name} does not match the response name of the xml element.");
            }

            XmlSerializer serializer = new XmlSerializer(
                typeof(T),
                body.GetNamespaceOfPrefix(Version)?.NamespaceName ?? body.GetDefaultNamespace().NamespaceName);
            using (var reader = body.CreateReader())
            {
                return serializer.Deserialize(reader) as T;
            }
        }

        /// <summary>
        /// Gets the fault exception <see cref="FaultException"/>
        /// Returns null if error could not be deserialized.
        /// </summary>
        /// <typeparam name="TServiceFaultDetailer">The type of ServiceFaultDetailer model.</typeparam>
        /// <param name="response">The http response.</param>
        /// <returns>instance of <see cref="FaultException"/>.</returns>
        private static async Task<FaultException> GetFaultException<TServiceFaultDetailer>(
            HttpResponseMessage response)
            where TServiceFaultDetailer : class
        {
            if (response.Content == null)
            {
                return new FaultException(new FaultReason(response.ReasonPhrase), new FaultCode("no content found on error"), response.RequestMessage.RequestUri.AbsoluteUri);
            }

            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            using var xmlReader = XmlReader.Create(new StringReader(responseText));
            var message = Message.CreateMessage(xmlReader, int.MaxValue, MessageVersion.Soap12WSAddressing10);
            var msgFault = MessageFault.CreateFault(message, int.MaxValue);

            var details = GetErrorDetails<TServiceFaultDetailer>(responseText);

            if (details.serviceFaultDetailer != null)
            {
                return new FaultException<TServiceFaultDetailer>(details.serviceFaultDetailer, msgFault.Reason, msgFault.Code, response.RequestMessage?.RequestUri.AbsoluteUri);
            }

            if (details.errorMessage != null)
            {
                return new FaultException(details.errorMessage);
            }

            return new FaultException(msgFault, response.RequestMessage?.RequestUri.AbsoluteUri);
        }

        private static (TServiceFaultDetailer? serviceFaultDetailer, string? errorMessage) GetErrorDetails<TServiceFaultDetailer>(string responseText)
            where TServiceFaultDetailer : class
        {
            XDocument document = XDocument.Parse(responseText);
            XElement? body = document.Root?.Descendants().FirstOrDefault(d => d.Name.LocalName == typeof(TServiceFaultDetailer).Name);
            if (body == null)
            {
                return (null, null);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(TServiceFaultDetailer), body.GetDefaultNamespace().NamespaceName);
            using (var reader = body.CreateReader())
            {
                return (serializer.Deserialize(reader) as TServiceFaultDetailer, null);
            }
        }
    }
}