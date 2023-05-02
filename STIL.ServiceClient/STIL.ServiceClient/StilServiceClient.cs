using STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;
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
        private readonly StringBuilder _urlBuilder = new();
        private HttpClient _stilHttpClient { get; set; }
        internal VeuClient VEU { get; private set; }
        
        public StilServiceClient(string baseUrl, X509Certificate2 clientAndSigningCertificate)
        {
            _clientCertificate = clientAndSigningCertificate;
            _signingCertificate = clientAndSigningCertificate;

            InstantiateClients(baseUrl);
        }

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
            _urlBuilder.Append(baseUrl.TrimEnd('/')).Append(_baseUrl);

            VEU = VeuClient.CreateInstance(this);
        }

        #region VeuClient

        internal class VeuClient
        {
            private readonly StilServiceClient _stilServiceClient;

            private VeuClient(StilServiceClient stilServiceClient)
            {
                _stilServiceClient = stilServiceClient;
                _stilServiceClient._urlBuilder.Append("/VEU");
            }

            internal static VeuClient CreateInstance(StilServiceClient stilServiceClient)
            {
                return new VeuClient(stilServiceClient);
            }

            public async Task<hentTilmeldingerResponse> HentTilmeldingerVeuInteressenter(HentTilmeldingerRequest dataRequest, CancellationToken cancellationToken = default)
            {
                var stilRequest = new StilSoapMessage<HentTilmeldingerRequest>(dataRequest);
                var signedRequest = stilRequest.GetSignedXml(_stilServiceClient._signingCertificate);

                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    request.Method = HttpMethod.Post;
                    request.Content = new StringContent(signedRequest, Encoding.UTF8, "application/soap+xml");
                    _stilServiceClient._urlBuilder.Append(nameof(HentTilmeldingerVeuInteressenter)).Append("v1");
                    request.RequestUri = new Uri(_stilServiceClient._urlBuilder.ToString(), UriKind.RelativeOrAbsolute);
                    var response = await _stilServiceClient._stilHttpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
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

                        switch (response.StatusCode)
                        {
                            case HttpStatusCode.OK:
                                return (await _stilServiceClient.ReadObjectResponseAsync<hentTilmeldingerResponse>(
                                        response,
                                        (IReadOnlyDictionary<string, IEnumerable<string>>)headers)
                                    .ConfigureAwait(false));

                            default:
                                throw new ArgumentOutOfRangeException("The HTTP status code of the response was not expected (" + ((int)response.StatusCode) + ").");
                        }
                    }
                    finally
                    {
                        response.Dispose();
                    }
                }
            }
        }

        #endregion VeuClient

        protected virtual async Task<T> ReadObjectResponseAsync<T>(
            HttpResponseMessage response,
            IReadOnlyDictionary<string, IEnumerable<string>> headers) where T : class
        {
            if (response == null || response.Content == null)
                return default;

            string str = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                XNamespace soap = XNamespace.Get("http://www.w3.org/2003/05/soap-envelope");
                XNamespace v1 = XNamespace.Get("http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0");

                var env = XDocument.Parse(str);
                var body = env.Root.Element(soap + "Body");
                var responseElement = body.Element(v1 + "hentTilmeldingerResponse");
                var s = new XmlSerializer(typeof(T));
                var result = s.Deserialize(responseElement.CreateReader()) as T;

                return result;
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Could not xml deserialize the response body string as " + typeof(T).FullName + ".", ex);
            }
        }

    }
}