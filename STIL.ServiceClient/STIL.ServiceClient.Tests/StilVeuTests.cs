using System.Security.Cryptography.X509Certificates;
using FluentAssertions;
using STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

namespace STIL.ServiceClient.Tests
{
    public class StilVeuTests
    {
        [Fact(Skip = "Only relevant when live testing locally")]
        [Trait("Category", "Integration")]
        public async Task Get_HentTilmeldingerVeuInteressenter_ReturnsCorrectResult()
        {
            var request = new HentTilmeldingerRequest
            {
                Identifier = new Entities.Entities.VEU.HentTilmeldingerVeuInteressenter.Identifier
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
                        Besked = new hentTilmeldingerRequest
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
            var baseUrl = "https://et.integrationsplatformen.dk";
            var stilServiceClient = new StilServiceClient(baseUrl, certificate);

            // Get the same 2 result just for fun.
            var result = await stilServiceClient.VEU.HentTilmeldingerVeuInteressenter(request);
            var result2 = await stilServiceClient.VEU.HentTilmeldingerVeuInteressenter(request);

            result.Should().NotBeNull();
            result2.Should().NotBeNull();

            result.Message.hentTilmeldingerResponse.Resultat.Resultat.PersonListe.Length.Should().Be(10);
        }
    }
}