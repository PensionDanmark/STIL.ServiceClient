﻿using STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;
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
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using STIL.Entities.Entities.VEU.HentUdbud;

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
    public class StilServiceClient
    {
        private readonly X509Certificate2 _clientCertificate;
        private readonly X509Certificate2 _signingCertificate;
        private readonly string _baseUrl = "/services";
        private string _version = "v1";
        private readonly StringBuilder _baseUrlBuilder = new();
        private HttpClient _stilHttpClient { get; set; }
        internal VeuClient VEU { get; private set; }

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
            _stilHttpClient = new HttpClient(handler);
            _baseUrlBuilder.Append(baseUrl.TrimEnd('/')).Append(_baseUrl);

            VEU = VeuClient.CreateInstance(this);
        }

        #region VeuClient

        internal class VeuClient
        {
            private readonly StilServiceClient _stilServiceClient;

            private VeuClient(StilServiceClient stilServiceClient)
            {
                _stilServiceClient = stilServiceClient;
                _stilServiceClient._baseUrlBuilder.Append("/VEU");
            }

            internal static VeuClient CreateInstance(StilServiceClient stilServiceClient)
            {
                return new VeuClient(stilServiceClient);
            }

            public async Task<hentTilmeldingerResponse> HentTilmeldingerVeuInteressenter(HentTilmeldingerRequest dataRequest, CancellationToken cancellationToken = default)
            {
                return await _stilServiceClient.SendSoapRequest<HentTilmeldingerRequest, hentTilmeldingerResponse>(nameof(HentTilmeldingerVeuInteressenter), dataRequest, cancellationToken: cancellationToken);
            }

            public async Task<HentUdbudResponse> HentUdbud(HentUdbudRequest dataRequest, CancellationToken cancellationToken = default)
            {
                return await _stilServiceClient.SendSoapRequest<HentUdbudRequest, HentUdbudResponse>(nameof(HentUdbud), dataRequest, cancellationToken: cancellationToken);
            }
        }

        #endregion VeuClient

        /// <summary>
        /// Deserialize response from xml.
        /// </summary>
        /// <typeparam name="T">The return type </typeparam>
        /// <param name="response">The response.</param>
        /// <param name="headers">The headers.</param>
        /// <returns>The deserialized response.</returns>
        /// <exception cref="InvalidOperationException">Thrown when document cannot be deserialized.</exception>
        protected virtual async Task<T?> ReadObjectResponseAsync<T>(
            HttpResponseMessage? response,
            IReadOnlyDictionary<string, IEnumerable<string>> headers) where T : class
        {
            if (response?.Content == null)
                return default;

            var str = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                var document = XDocument.Parse(str);
                if (document?.Root is null)
                {
                    throw new NullReferenceException("Document root element does not exist");
                }

                var soapEnvelope = document.Root.GetNamespaceOfPrefix("soap");
                var soapBody = document.Root.Element(soapEnvelope + "Body");
                if (soapBody?.FirstNode is null)
                {
                    throw new NullReferenceException("Soap body element does not exist");
                }

                var responseName = ((XElement)soapBody.FirstNode).Name.LocalName;
                if (responseName != (typeof(T).Name))
                {
                    throw new InvalidOperationException($"The response type: {typeof(T).Name} does not match the response name: {responseName} of the xml element.");
                }

                var xmlSerializer = new XmlSerializer(typeof(T));
                var result = xmlSerializer.Deserialize(soapBody.FirstNode.CreateReader()) as T;
                return result;
            }
            catch (Exception ex)
            {
                throw new ApiException("Could not deserialize the response body string as " + typeof(T).FullName + ".", (int)response.StatusCode, str, response.RequestMessage?.RequestUri.AbsoluteUri, headers, ex);
            }
        }

        protected virtual async Task<TResponse> SendSoapRequest<TRequest, TResponse>(string methodName, TRequest dataRequest, CancellationToken cancellationToken = default) 
            where TRequest : class 
            where TResponse : class
        {
            var stilRequest = new StilSoapMessage<TRequest>(dataRequest);
            var signedRequest = stilRequest.GetSignedXml(_signingCertificate);

            using (HttpRequestMessage request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.Content = new StringContent(signedRequest, Encoding.UTF8, "application/soap+xml");
                var urlBuilder = _baseUrlBuilder;
                urlBuilder.Append($"/{methodName}/{Version}");
                request.RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute);
                var response = await _stilHttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
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
                        return (await ReadObjectResponseAsync<TResponse>(
                                response,
                                (IReadOnlyDictionary<string, IEnumerable<string>>)headers)
                            .ConfigureAwait(false));
                    }

                    switch (response.StatusCode)
                    {
                        default:
                            var requestUrl = response.RequestMessage?.RequestUri.AbsoluteUri;
                            var responseData = response.ReasonPhrase + $"\nRequestUri: {requestUrl}";
                            throw new ApiException("The HTTP status code of the response was not expected (" + ((int)response.StatusCode) + ").", (int)response.StatusCode, responseData, response.RequestMessage?.RequestUri.AbsoluteUri, headers, null);
                    }
                }
                finally
                {
                    response.Dispose();
                }
            }
        }


    }
}