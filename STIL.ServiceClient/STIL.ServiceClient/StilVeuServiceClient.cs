using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using STIL.Entities.VEU.HentOptagedePladser;
using STIL.Entities.VEU.HentTilmeldingerVeuInteressenter;
using STIL.Entities.VEU.HentUdbud;

namespace STIL.ServiceClient;

/// <inheritdoc />
public class StilVeuServiceClient : IStilVeuServiceClient
{
    private const string UrlAreaAffix = "/VEU";
    private readonly IStilServiceClient _stilServiceClient;

    /// <summary>
    /// Initializes a new instance of the <see cref="StilVeuServiceClient"/> class.
    /// </summary>
    /// <param name="baseUrl">The baseUrl for the SOAP services, ex. https://et.integrationsplatformen.dk.</param>
    /// <param name="clientAndSigningCertificate">The certificate used for both the http client and xml signing.</param>
    public StilVeuServiceClient(string baseUrl, X509Certificate2 clientAndSigningCertificate)
    {
        _stilServiceClient = new StilServiceClient(baseUrl, UrlAreaAffix, clientAndSigningCertificate, clientAndSigningCertificate);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="StilVeuServiceClient" /> class.
    /// </summary>
    /// <param name="baseUrl">The baseUrl for the SOAP services, ex. https://et.integrationsplatformen.dk.</param>
    /// <param name="clientCertificate">The http client certificate.</param>
    /// <param name="signingCertificate">The xml signing certificate.</param>
    public StilVeuServiceClient(string baseUrl, X509Certificate2 clientCertificate, X509Certificate2 signingCertificate)
    {
        _stilServiceClient = new StilServiceClient(baseUrl, UrlAreaAffix, clientCertificate, signingCertificate);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="StilVeuServiceClient" /> class.
    /// </summary>
    /// <param name="stilServiceClient">The STIL service client.</param>
    internal StilVeuServiceClient(IStilServiceClient stilServiceClient)
    {
        _stilServiceClient = stilServiceClient;
    }

    /// <inheritdoc />
    public async Task<HentOptagedePladserResponse> HentOptagedePladser(
        HentOptagedePladserRequest dataRequest, CancellationToken cancellationToken = default)
    {
        return await _stilServiceClient.SendSoapRequest<HentOptagedePladserRequest, HentOptagedePladserResponse, Entities.VEU.HentOptagedePladser.ServiceFaultDetailer>(
            nameof(HentOptagedePladser), dataRequest, cancellationToken: cancellationToken);
    }

    /// <inheritdoc />
    public async Task<hentTilmeldingerResponse> HentTilmeldingerVeuInteressenter(
        HentTilmeldingerRequest dataRequest, CancellationToken cancellationToken = default)
    {
        return await _stilServiceClient.SendSoapRequest<HentTilmeldingerRequest, hentTilmeldingerResponse, Entities.VEU.HentTilmeldingerVeuInteressenter.ServiceFaultDetailer>(
            nameof(HentTilmeldingerVeuInteressenter), dataRequest, cancellationToken: cancellationToken);
    }

    /// <inheritdoc />
    public async Task<HentUdbudResponse> HentUdbud(HentUdbudRequest dataRequest, CancellationToken cancellationToken = default)
    {
        return await _stilServiceClient.SendSoapRequest<HentUdbudRequest, HentUdbudResponse, Entities.VEU.HentUdbud.ServiceFaultDetailer>(
            nameof(HentUdbud),
            dataRequest,
            cancellationToken: cancellationToken);
    }
}