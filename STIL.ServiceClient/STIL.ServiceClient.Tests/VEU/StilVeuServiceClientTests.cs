using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using STIL.Entities.VEU.HentOptagedePladser;
using STIL.Entities.VEU.HentTilmeldingerVeuInteressenter;
using STIL.Entities.VEU.HentUdbud;
using STIL.ServiceClient.Tests.Extensions;
using STIL.ServiceClient.Tests.Util;

namespace STIL.ServiceClient.Tests.VEU;

public class StilVeuServiceClientTests
{
    [Fact]
    public async Task HentOptagedePladser_ValidResponse_ReturnsExpectedResult()
    {
        // Arrange
        var fileName = "HentOptagedePladser_ValidResponse.xml";
        var httpClientHandlerMock = new Mock<HttpClientHandler>();

        httpClientHandlerMock.SetupAnyRequest()
            .ReturnsResponse(HttpStatusCode.OK, response =>
            {
                response.Content = new StringContent(TestHelper.GetXmlContentFromFile(fileName));
            }).Verifiable();

        var sut = new StilVueServiceClientBuilder().With(httpClientHandlerMock).Build();

        // Act
        var request = new HentOptagedePladserRequest1();
        var response = await sut.HentOptagedePladser(request);

        // Assert
        response.Should().NotBeNull();
        httpClientHandlerMock.Verify();
        (httpClientHandlerMock.Invocations.ElementAt(0).Arguments.ElementAt(0) as HttpRequestMessage)!.RequestUri
            .Should().Be("http://test/services/VEU/HentOptagedePladser/v1");
        response.CorrelationID.Should().Be("e3f45e63-eb45-4df2-96ae-bde3038be385");
        response.Identifier.SystemName.Should().Be("Test");
        response.Identifier.SystemTransactionID.Should().Be("5eeda783-8a01-439c-9fc4-b0ae2de4a62a");
        response.Message.HentOptagedePladserResponse.Behandlingstidspunkt.Should()
            .Be(DateTime.Parse("2023-05-13T08:55:13.119+02:00"));
        response.Message.HentOptagedePladserResponse.HoldListe.Should().HaveCount(1);
        response.Message.HentOptagedePladserResponse.HoldListe.ElementAt(0).AktiGUID.Should().Be("513e88f8c3ac11eb85290242ac130003");
        response.Message.HentOptagedePladserResponse.HoldListe.ElementAt(0).HoldPladsListe.Should().HaveCount(2);
        response.Message.HentOptagedePladserResponse.HoldListe.ElementAt(0).HoldPladsListe.ElementAt(0)
            .OptagetAntalPladser.Should().Be(3);
        response.Message.HentOptagedePladserResponse.HoldListe.ElementAt(0).HoldPladsListe.ElementAt(0).Dato.Should()
            .Be(DateTime.Parse("2021-06-01+02:00"));
    }

    [Fact]
    public async Task HentOptagedePladser_BadRequest400_ThrowsExpectedFaultException()
    {
        // Arrange
        var fileName = "HentOptagedePladser_ErrorResponse_400.xml";
        var httpClientHandlerMock = new Mock<HttpClientHandler>();

        httpClientHandlerMock.SetupAnyRequest()
            .ReturnsResponse(HttpStatusCode.BadRequest,
                response => { response.Content = new StringContent(TestHelper.GetXmlContentFromFile(fileName)); })
            .Verifiable();

        var sut = new StilVueServiceClientBuilder().With(httpClientHandlerMock).Build();

        // Act
        var request = new HentOptagedePladserRequest1();
        var exception = await Assert.ThrowsAsync<FaultException<STIL.Entities.VEU.HentOptagedePladser.ServiceFaultDetailer>>(() => sut.HentOptagedePladser(request));

        // Assert
        exception.Reason.ToString().Should().Be("Input error");
        exception.Code.IsSenderFault.Should().BeTrue();
        exception.Action.Should().Be("http://test/services/VEU/HentOptagedePladser/v1");
        exception.Detail.CorrelationID.Should().Be("bcf499bf-ab8f-4632-8cde-ee899a90d8ab");
        exception.Detail.Details.Should()
            .Contain(@"com.sun.org.apache.xerces.internal.jaxp.validation.XMLSchema@19652c7e");
        exception.Detail.ErrorCode.Should().Be("IPL000002");
        exception.Detail.ErrorMessage.Should().Be("The request is invalid according to the schema definition. Check details for further information");
    }

    [Fact]
    public async Task HentTilmeldingerVeuInteressenter_ValidResponse_ReturnsExpectedResult()
    {
        // Arrange
        var fileName = "HentTilmeldingerVeuInteressenter_ValidResponse.xml";
        var httpClientHandlerMock = new Mock<HttpClientHandler>();

        httpClientHandlerMock.SetupAnyRequest()
            .ReturnsResponse(HttpStatusCode.OK, response =>
            {
                response.Content = new StringContent(TestHelper.GetXmlContentFromFile(fileName));
            }).Verifiable();

        var sut = new StilVueServiceClientBuilder().With(httpClientHandlerMock).Build();

        // Act
        var request = new HentTilmeldingerRequest();
        var response = await sut.HentTilmeldingerVeuInteressenter(request);

        // Assert
        response.Should().NotBeNull();
        httpClientHandlerMock.Verify();
        (httpClientHandlerMock.Invocations.ElementAt(0).Arguments.ElementAt(0) as HttpRequestMessage)!.RequestUri
            .Should().Be("http://test/services/VEU/HentTilmeldingerVeuInteressenter/v1");
        response.CorrelationID.Should().Be("3e5f08f7-53c0-4f9e-9743-b83cb8c65f42");
        response.Identifier.SystemName.Should().Be("Test");
        response.Identifier.SystemTransactionID.Should().Be("01c688af-c401-44ad-b520-eb7238e72a96");
        response.Message.hentTilmeldingerResponse.Resultat.Resultat.PersonListe.Length.Should().Be(3);
        response.Message.hentTilmeldingerResponse.Resultat.Resultat.PersonListe.ElementAt(0).CPRnummer.Should()
            .Be("0101198001");
        response.Message.hentTilmeldingerResponse.Resultat.Resultat.PersonListe.ElementAt(0).TilmeldingsListe
            .ElementAt(0).Skole.Navn.Should().Be("Hotel- og Restaurantskolen");
    }

    [Fact]
    public async Task HentTilmeldingerVeuInteressenter_BadRequest400_WrongCprFormat_ThrowsExpectedFaultException()
    {
        // Arrange
        var fileName = "HentTilmeldingerVeuInteressenter_ErrorResponse_400.xml";
        var httpClientHandlerMock = new Mock<HttpClientHandler>();

        httpClientHandlerMock.SetupAnyRequest()
            .ReturnsResponse(HttpStatusCode.BadRequest, response =>
            {
                response.Content = new StringContent(TestHelper.GetXmlContentFromFile(fileName));
            }).Verifiable();

        var sut = new StilVueServiceClientBuilder().With(httpClientHandlerMock).Build();

        // Act
        var request = new HentTilmeldingerRequest
        {
            Identifier = new STIL.Entities.VEU.HentTilmeldingerVeuInteressenter.Identifier
            {
                SystemName = "Test",
                SystemTransactionID = Guid.NewGuid().ToString()
            },
            Message = new HentTilmeldingerRequestMessage
            {
                hentTilmeldinger = new hentTilmeldinger
                {
                    wsSyncReqModtagerV2 = new wsSyncReqModtagerV2
                    {
                        ModtagerSystemID = "Test",
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
                            CPRnummerListe = new[]
                            {
                                "0101198000123", "0101198001", "0101198002", "0101198003", "0101198004", "0101198005",
                                "0101198006", "0101198007", "0101198008", "0101198009"
                            }
                        }
                    }
                }
            }
        };

        var exception = await Assert.ThrowsAsync<FaultException<STIL.Entities.VEU.HentTilmeldingerVeuInteressenter.ServiceFaultDetailer>>(() => sut.HentTilmeldingerVeuInteressenter(request));

        // Assert
        exception.Reason.ToString().Should().Be("Input error");
        exception.Code.IsSenderFault.Should().BeTrue();
        exception.Action.Should().Be("http://test/services/VEU/HentTilmeldingerVeuInteressenter/v1");
        exception.Detail.CorrelationID.Should().Be("7705dbac-c24d-47b3-bcc8-18ca38e62fb7");
        exception.Detail.Details.Should()
            .Contain(@"org.xml.sax.SAXParseException: cvc-maxLength-valid: Value '0101198000123' with length = '13' is not facet-valid with respect to maxLength '10' for type '#AnonType_CPRnummercprNummerListe'");
        exception.Detail.ErrorCode.Should().Be("IPL000002");
        exception.Detail.ErrorMessage.Should().Be("The request is invalid according to the schema definition. Check details for further information");
    }

    [Fact]
    public async Task HentUdbud_ValidResponse_ReturnsExpectedResult()
    {
        // Arrange
        var fileName = "HentUdbud_ValidResponse.xml";
        var httpClientHandlerMock = new Mock<HttpClientHandler>();

        httpClientHandlerMock.SetupAnyRequest()
            .ReturnsResponse(HttpStatusCode.OK, response =>
            {
                response.Content = new StringContent(TestHelper.GetXmlContentFromFile(fileName));
            }).Verifiable();

        var sut = new StilVueServiceClientBuilder().With(httpClientHandlerMock).Build();

        // Act
        var request = new HentUdbudRequest();
        var response = await sut.HentUdbud(request);

        // Assert
        response.Should().NotBeNull();
        httpClientHandlerMock.VerifyAnyRequest(Times.Exactly(1));
        (httpClientHandlerMock.Invocations.ElementAt(0).Arguments.ElementAt(0) as HttpRequestMessage)!.RequestUri
            .Should().Be("http://test/services/VEU/HentUdbud/v1");
        response.Identifier.SystemTransactionID.Should().Be("ce9d53d0-490e-4b1f-abfe-d82160170775");
        response.Message.HentUdbudResponse.Modtager.ModtagerSystemTransaktionsID.Should()
            .Be("2e240785-06a2-41b6-bc44-91babe5e752f");
        response.Message.HentUdbudResponse.Behandlingstidspunkt.Should()
            .Be(DateTime.Parse("2023-05-12T09:26:12.345+02:00"));
    }

    [Fact]
    public async Task HentUdbud_BadRequest400_ThrowsExpectedFaultException()
    {
        // Arrange
        var fileName = "HentUdbud_ErrorResponse_400.xml";
        var httpClientHandlerMock = new Mock<HttpClientHandler>();

        httpClientHandlerMock.SetupAnyRequest()
            .ReturnsResponse(HttpStatusCode.BadRequest, response =>
            {
                response.Content = new StringContent(TestHelper.GetXmlContentFromFile(fileName));
            }).Verifiable();

        var sut = new StilVueServiceClientBuilder().With(httpClientHandlerMock).Build();

        // Act
        var request = new HentUdbudRequest();
        var exception = await Assert.ThrowsAsync<FaultException<STIL.Entities.VEU.HentUdbud.ServiceFaultDetailer>>(() => sut.HentUdbud(request));

        // Assert
        httpClientHandlerMock.VerifyAnyRequest(Times.Exactly(1)); // 0 retries for 400 errors. 1 try in total.
        exception.Reason.ToString().Should().Be("Input error");
        exception.Code.IsSenderFault.Should().BeTrue();
        exception.Action.Should().Be("http://test/services/VEU/HentUdbud/v1");
        exception.Detail.CorrelationID.Should().Be("6e9c5b4d-67a8-430f-89cf-da9ceeac0f7f");
        exception.Detail.Details.Should()
            .Contain(@"cvc-complex-type.2.4.b: The content of element 'HentUdbudRequest' is not complete");
        exception.Detail.ErrorCode.Should().Be("IPL000002");
        exception.Detail.ErrorMessage.Should().Be("The request is invalid according to the schema definition. Check details for further information");
    }

    [Fact]
    public async Task HentUdbud_TransientServerError500_ThrowsExpectedFaultExceptionAndRetry()
    {
        // Arrange
        var fileName = "HentUdbud_ErrorResponse_500.xml";
        
        var httpClientHandlerMock = new Mock<HttpClientHandler>();

        httpClientHandlerMock.SetupAnyRequest()
            .ReturnsResponse(HttpStatusCode.ServiceUnavailable, response =>
            {
                response.Content = new StringContent(TestHelper.GetXmlContentFromFile(fileName));
            }).Verifiable();

        var sut = new StilVueServiceClientBuilder().With(httpClientHandlerMock).Build();

        // Act
        var request = new HentUdbudRequest();
        var exception = await Assert.ThrowsAsync<FaultException<STIL.Entities.VEU.HentUdbud.ServiceFaultDetailer>>(() => sut.HentUdbud(request));

        // Assert
        httpClientHandlerMock.VerifyAnyRequest(Times.Exactly(2)); // 1 retry = 2 tries in total.
        exception.Reason.ToString().Should().Be("Internal error");
        exception.Code.IsSenderFault.Should().BeFalse();
        exception.Action.Should().Be("http://test/services/VEU/HentUdbud/v1");
        exception.Detail.CorrelationID.Should().Be("b041be7e-cffb-4b72-9282-894c5ef02509");
        exception.Detail.ErrorCode.Should().Be("IPL000001");
        exception.Detail.ErrorMessage.Should().Be("An unexpected error has occurred while processing the request. Contact the support helpdesk for Integrationsplatformen and attach the Correlation-ID from this message");
    }

    #region Integration live unit testing

    [Fact(Skip = "Only relevant when live testing locally")]
    [Trait("Category", "Integration")]
    public async Task Integration_HentOptagedePladser_ReturnsCorrectResult()
    {
        // Arrange
        var request = new HentOptagedePladserRequest1()
        {
            Identifier = new STIL.Entities.VEU.HentOptagedePladser.Identifier
            {
                SystemName = "Test",
                SystemTransactionID = Guid.NewGuid().ToString()
            },
            Message = new HentOptagedePladserRequestMessage()
            {

                HentOptagedePladserRequest = new HentOptagedePladserRequest()
                {
                    Modtager = new STIL.Entities.VEU.HentOptagedePladser.ModtagerType()
                    {
                        ModtagerSystemId = "Test",
                        ModtagerSystemTransaktionsID = Guid.NewGuid().ToString()
                    },

                    //get all the distinct aktiguids
                    AktiGUIDListe = new[]
                    {
                        "513e88f8c3ac11eb85290242ac130003",
                        "723f03cd456740a680cfd71500fb5fb5",
                        "24212acb3aee47e785b354cd7e0bf120"
                    }
                }
            }
        };

        var baseUrl = "https://et.integrationsplatformen.dk";
        IStilVeuServiceClient stilServiceClient = new StilVeuServiceClient(baseUrl, GetCertificateByThumbprint("87BA4C291BBBCDBC118723EFBE05C8785D1A5C32"));

        // Act
        var result = await stilServiceClient.HentOptagedePladser(request);

        // Assert / debug
        result.Should().NotBeNull();
    }

    [Fact(Skip = "Only relevant when live testing locally")]
    [Trait("Category", "Integration")]
    public async Task Integration_HentTilmeldingerVeuInteressenter_ReturnsCorrectResult()
    {
        // Arrange
        var request = new HentTilmeldingerRequest
        {
            Identifier = new STIL.Entities.VEU.HentTilmeldingerVeuInteressenter.Identifier
            {
                SystemName = "Test",
                SystemTransactionID = Guid.NewGuid().ToString()
            },
            Message = new HentTilmeldingerRequestMessage
            {
                hentTilmeldinger = new hentTilmeldinger
                {
                    wsSyncReqModtagerV2 = new wsSyncReqModtagerV2
                    {
                        ModtagerSystemID = "Test",
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
                            CPRnummerListe = new[] { "0101198000123", "0101198001", "0101198002", "0101198003", "0101198004", "0101198005", "0101198006", "0101198007", "0101198008", "0101198009" }
                        }
                    }
                }
            }
        };

        var baseUrl = "https://et.integrationsplatformen.dk";
        IStilVeuServiceClient stilServiceClient = new StilVeuServiceClient(baseUrl, GetCertificateByThumbprint("87BA4C291BBBCDBC118723EFBE05C8785D1A5C32"));

        // Act
        var result = await stilServiceClient.HentTilmeldingerVeuInteressenter(request);

        // Assert / debug
        result.Should().NotBeNull();
        result.Message.hentTilmeldingerResponse.Resultat.Resultat.PersonListe.Length.Should().Be(10);
    }

    [Fact(Skip = "Only relevant when live testing locally")]
    [Trait("Category", "Integration")]
    public async Task Integration_HentUdbud_ReturnsCorrectResult()
    {
        // Arrange
        var request = new HentUdbudRequest()
        {
            Identifier = new Entities.VEU.HentUdbud.Identifier
            {
                SystemName = "Test",
                SystemTransactionID = Guid.NewGuid().ToString()
            },
            Message = new HentUdbudRequestMessage()
            {
                HentUdbudRequest = new HentUdbudRequest1()
                {
                    Indhold = new IndholdRequestType()
                    {
                        DsNummerListe = new[] { "123" }
                    },
                    Modtager = new STIL.Entities.VEU.HentUdbud.ModtagerType()
                    {
                        ModtagerSystemId = "Test",
                        ModtagerSystemTransaktionsID = Guid.NewGuid().ToString(),
                    }
                }
            }
        };

        var baseUrl = "https://et.integrationsplatformen.dk";
        IStilVeuServiceClient stilServiceClient = new StilVeuServiceClient(baseUrl, GetCertificateByThumbprint("87BA4C291BBBCDBC118723EFBE05C8785D1A5C32"));

        // Act
        var result = await stilServiceClient.HentUdbud(request);

        // Assert / debug
        result.Should().NotBeNull();
    }

    #endregion

    private static X509Certificate2 GetCertificateByThumbprint(string thumbprint)
    {
        // Retrieve certificate locally.
        var certStore = new X509Store(StoreLocation.CurrentUser);
        certStore.Open(OpenFlags.ReadOnly);
        return certStore.Certificates.Find(X509FindType.FindByThumbprint, thumbprint, validOnly: false).FirstOrDefault()!;
    }
}