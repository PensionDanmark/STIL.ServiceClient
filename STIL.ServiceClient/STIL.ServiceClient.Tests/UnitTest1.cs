using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using STIL.ServiceClient.Util.SoapHelper;
using STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

namespace STIL.ServiceClient.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var request = new HentTilmeldingerRequest
            {
                Identifier = new Identifier
                {
                    SystemName = "MGL3010",
                    SystemTransactionID = Guid.NewGuid().ToString()
                },
                Message = new HentTilmeldingerRequestMessage
                {
                    hentTilmeldinger = new hentTilmeldinger
                    {
                        wsSyncReqModtagerV2 = new wsSyncReqModtagerV2
                        {
                            ModtagerSystemID = "MGL3010",
                            ModtagerSystemTransaktionsID = Guid.NewGuid().ToString()
                        },
                        Besked = new HentTilmeldingerRequest.hentTilmeldingerRequest
                        {
                            Indhold = new hentTilmeldingerReqIndhold
                            {
                                FraDato = new DateTime(2022, 01, 01),
                                TilDato = new DateTime(2022, 02, 15),
                                InstNr = "A00827",
                                CVRnr = "0",
                                CPRnummerListe = new[] { "0101198000", "0101198001", "0101198002", "0101198003", "0101198004", "0101198005", "0101198006", "0101198007", "0101198008", "0101198009" }
                            }
                        }
                    }
                }
            };

            var thumbprint = "87BA4C291BBBCDBC118723EFBE05C8785D1A5C32";
            var certStore = new X509Store(StoreLocation.CurrentUser);
            certStore.Open(OpenFlags.ReadOnly);
            X509Certificate2? certificate = certStore.Certificates.Find(X509FindType.FindByThumbprint, thumbprint, validOnly: false).FirstOrDefault();
            var handler = new HttpClientHandler()
            {
                ClientCertificates = { certificate }
            };
            var stilClient = new HttpClient(handler);

            var stilRequest = new StilSoapMessage<HentTilmeldingerRequest>(request);
            var signedRequest = stilRequest.GetSignedXml(certificate);
            var content = new StringContent(signedRequest, Encoding.UTF8, "application/soap+xml");
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, "https://et.integrationsplatformen.dk/services/VEU/HentTilmeldingerVeuInteressenter/v1");
            httpRequest.Content = content;
            var response = await stilClient.SendAsync(httpRequest, HttpCompletionOption.ResponseHeadersRead);
            var textResponse = await response.Content.ReadAsStringAsync();
            XNamespace soap = XNamespace.Get("http://www.w3.org/2003/05/soap-envelope");
            XNamespace v1 = XNamespace.Get("http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0");

            var env = XDocument.Parse(textResponse);
            var body = env.Root.Element(soap + "Body");
            var responseElement = body.Element(v1 + "hentTilmeldingerResponse");
            var s = new XmlSerializer(typeof(hentTilmeldingerResponse));
            var x = s.Deserialize(responseElement.CreateReader()) as hentTilmeldingerResponse;
        }
    }
}