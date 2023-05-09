using STIL.ServiceClient.Util.SoapHelper;
using System;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using STIL.ServiceClient.Properties;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.ServiceModel.Channels;
using System.Xml;
using System.IO;
using System.ServiceModel;
using STIL.Entities.Entities.VEU.HentUdbud;
using STIL.Entities.Common;
using STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

namespace STIL.ServiceClient
{
    /// <summary>
    /// C# Service Client to interact with the SOAP services provided by Styrelsen for IT og Læring (STIL).
    /// Link to PensionDanmark project documentation: 
    /// <see cref="https://github.com/PensionDanmark/STIL.ServiceClient"/>.
    ///
    /// Link to STIL service documentation:
    /// <see cref="https://viden.stil.dk/display/OFFintegrationsplatformen/Services"/>.
    /// 
    /// <example>
    /// using System.Security.Cryptography.X509Certificates;
    ///
    /// // Load your certificate
    /// X509Certificate2 certificate = new X509Certificate2("path/to/your/certificate.pfx", "your-password");
    ///
    /// // Create a StilServiceClient instance
    /// var stilServiceClient = new StilServiceClient(certificate);
    ///
    /// // Create a request for the HentTilmeldingerVeuInteressenter method
    /// HentTilmeldingerRequest request = new HentTilmeldingerRequest
    /// {
    ///     // ... set the properties of the request
    /// };
    ///
    /// // Call the HentTilmeldingerVeuInteressenter method and get the response
    /// var response = await stilServiceClient.VEU.HentTilmeldingerVeuInteressenter(request);
    ///
    /// // Use the response data
    /// Console.WriteLine($"Number of tilmeldinger: {result.Message.hentTilmeldingerResponse.Resultat.Resultat.PersonListe.Length}");
    /// </example>

    /// </summary>
    public partial class StilServiceClient : IStilServiceClient
    {
        private readonly X509Certificate2 _clientCertificate;
        private readonly X509Certificate2 _signingCertificate;
        private readonly string _baseUrl = "/services";
        private string _version = "v1";
        private readonly StringBuilder _baseUrlBuilder = new();
        private HttpClient StilHttpClient { get; set; }
        /// <summary>
        /// The STIL VEU area.
        /// </summary>
        public VeuClient VEU { get; private set; }

        /// <summary>
        /// Sets the api version. Default: /v1
        /// </summary>
        public string Version
        {
            get => this._version;
            set => this._version = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StilServiceClient" /> class.
        /// </summary>
        /// <param name="baseUrl">The baseUrl for the SOAP services, ex. https://et.integrationsplatformen.dk</param>
        /// <param name="clientAndSigningCertificate">The certificate used for both the http client and xml signing.</param>
        public StilServiceClient(string baseUrl, X509Certificate2 clientAndSigningCertificate)
        {
            _clientCertificate = clientAndSigningCertificate;
            _signingCertificate = clientAndSigningCertificate;

            InstantiateClients(baseUrl);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StilServiceClient" /> class.
        /// </summary>
        /// <param name="baseUrl">The baseUrl for the SOAP services, ex. https://et.integrationsplatformen.dk.</param>
        /// <param name="clientCertificate">The http client certificate.</param>
        /// <param name="signingCertificate">The xml signing certificate.</param>
        public StilServiceClient(string baseUrl, X509Certificate2 clientCertificate, X509Certificate2 signingCertificate)
        {
            _clientCertificate = clientCertificate;
            _signingCertificate = signingCertificate;

            InstantiateClients(baseUrl);
        }

        private void InstantiateClients(string baseUrl)
        {
            Guard.AgainstNullOrEmpty(baseUrl, nameof(baseUrl));

            var handler = new HttpClientHandler()
            {
                ClientCertificates = { _clientCertificate },

            };
            StilHttpClient = new HttpClient(handler);
            _baseUrlBuilder.Append(baseUrl.TrimEnd('/')).Append(_baseUrl);

            VEU = VeuClient.CreateInstance(this);
        }

        /// <summary>
        /// Deserialize response from xml.
        /// </summary>
        /// <typeparam name="T">The return type </typeparam>
        /// <param name="response">The response.</param>
        /// <param name="headers">The headers.</param>
        /// <returns>The deserialized response.</returns>
        /// <exception cref="ApiException">Thrown when document cannot be deserialized.</exception>

        protected virtual async Task<T?> ReadObjectResponseAsync<T>(
            HttpResponseMessage? response,
            IReadOnlyDictionary<string, IEnumerable<string>> headers) where T : class
        {
            if (response?.Content == null)
            {
                return default;
            }

            string? responseText = null;
            try
            {
                responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                XDocument document = XDocument.Parse(responseText);
                XElement? body = document.Root?.Descendants().FirstOrDefault(d => d.Name.LocalName == typeof(T).Name);
                if (body == null)
                {
                    throw new InvalidOperationException($"The response type: {typeof(T).Name} does not match the response name of the xml element.");
                }

                XmlSerializer serializer = new XmlSerializer(typeof(T), body.GetNamespaceOfPrefix(Version)?.NamespaceName ?? body.GetDefaultNamespace().NamespaceName);
                using (var reader = body.CreateReader())
                {
                    return serializer.Deserialize(reader) as T;
                }
            }
            catch (Exception ex)
            {
                throw new ApiException($"Could not deserialize the response body string as {typeof(T).Name}.", (int)response.StatusCode, responseText, response.RequestMessage?.RequestUri.AbsoluteUri, headers, ex);
            }
        }

        /// <summary>
        /// Gets the deserialized error object as <see cref="IServiceFaultDetailer"/>
        /// Returns null if error could not be deserialized.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response">The http response.</param>
        /// <returns>The deserialized instance of <see cref="IServiceFaultDetailer"/>.</returns>
        protected virtual async Task<FaultException?> GetFaultException<T>(
            HttpResponseMessage? response) where T : class
        {
            if (response?.Content == null)
            {
                return default;
            }

            try
            {
                using (var memStream = await response.Content.ReadAsStreamAsync())
                {
                    var xmlReader = new XmlTextReader(memStream);
                    var message = Message.CreateMessage(xmlReader, int.MaxValue, MessageVersion.Soap12WSAddressing10);
                    var msgFault = MessageFault.CreateFault(message, int.MaxValue);
                    var details = await GetErrorDetails<T>(response);

                    if (details.serviceFaultDetailer != null)
                    {
                        return new FaultException<T>(details.serviceFaultDetailer, msgFault.Reason, msgFault.Code, response.RequestMessage?.RequestUri.AbsoluteUri);
                    }

                    if (details.errorMessage != null)
                    {
                        return new FaultException(details.errorMessage);
                    }

                    return new FaultException(msgFault, response.RequestMessage?.RequestUri.AbsoluteUri);
                }
            }
            catch (Exception ex)
            {
                return new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// Send Soap Request method.
        /// Can be overridden in any derived classes.
        /// </summary>
        /// <typeparam name="TRequest">The request type.</typeparam>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <typeparam name="TServiceFaultDetailer">The service fault detailer type.</typeparam>
        /// <param name="methodName">The method name used in request uri.</param>
        /// <param name="dataRequest">The data request body.</param>
        /// <param name="serviceFaultDetailer">The service fault detailer model when error happens.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        /// <exception cref="ApiException">Thrown when</exception>
        protected virtual async Task<TResponse> SendSoapRequest<TRequest, TResponse, TServiceFaultDetailer>(string methodName, TRequest dataRequest, CancellationToken cancellationToken = default)
            where TRequest : class
            where TResponse : class
            where TServiceFaultDetailer : class
        {
            // TODO: Implement Polly retry policies, for 500 / 503 connection fails.
            var stilRequest = new StilSoapMessage<TRequest>(dataRequest);
            var signedRequest = stilRequest.GetSignedXml(_signingCertificate);

            using (HttpRequestMessage request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.Content = new StringContent(signedRequest, Encoding.UTF8, "application/soap+xml");
                var urlBuilder = _baseUrlBuilder;
                urlBuilder.Append($"/{methodName}/{Version}");
                request.RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute);
                var response = await StilHttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false)
                    ?? throw new NullReferenceException($"{nameof(StilHttpClient.SendAsync)} returned null for response type: {typeof(TResponse).Name}.");

                try
                {
                    var headers =
                        response.Headers
                            .ToDictionary<KeyValuePair<string, IEnumerable<string>>, string, IEnumerable<string>>(
                                h => h.Key, h => h.Value);
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (KeyValuePair<string, IEnumerable<string>> header in (HttpHeaders)response.Content
                                         .Headers)
                            headers[header.Key] = header.Value;
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        return await ReadObjectResponseAsync<TResponse>(response, headers).ConfigureAwait(false)
                               ?? throw new NullReferenceException($"{nameof(ReadObjectResponseAsync)} returned null for response type: {typeof(TResponse).Name}.");
                    }

                    switch (response.StatusCode)
                    {
                        // TODO: Implement other known status code failures.
                        case HttpStatusCode.BadRequest:
                            {
                                if (response.Content is null)
                                {
                                    throw new ApiException("Bad request", (int)response.StatusCode, "No error response found.", response.RequestMessage?.RequestUri.AbsoluteUri, headers, null!);
                                }

                                var faultException = await GetFaultException<TServiceFaultDetailer>(response);
                                throw new ApiException("Bad request", (int)response.StatusCode, faultException?.Message, response.RequestMessage?.RequestUri.AbsoluteUri, headers, faultException!);
                            }

                        default:
                            var requestUrl = response.RequestMessage?.RequestUri.AbsoluteUri;
                            var responseData = response.ReasonPhrase + $"\nRequestUri: {requestUrl}";
                            throw new ApiException("The HTTP status code of the response was not expected (" + ((int)response.StatusCode) + ").", (int)response.StatusCode, responseData, response.RequestMessage?.RequestUri.AbsoluteUri, headers, null!);
                    }
                }

                finally
                {
                    response.Dispose();
                }
            }
        }

        private async Task<(T? serviceFaultDetailer, string? errorMessage)> GetErrorDetails<T>(HttpResponseMessage response) where T : class
        {
            try
            {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                XDocument document = XDocument.Parse(responseText);
                XElement? body = document.Root?.Descendants().FirstOrDefault(d => d.Name.LocalName == typeof(T).Name);
                if (body == null)
                {
                    return (null, null);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(T), body.GetDefaultNamespace().NamespaceName);
                using (var reader = body.CreateReader())
                {
                    return (serializer.Deserialize(reader) as T, null);
                }
            }
            catch (Exception ex)
            {
                return (null, $"Failed to get additional error details of {typeof(T)} from response. Error: {ex.Message}");
            }
        }
    }
}