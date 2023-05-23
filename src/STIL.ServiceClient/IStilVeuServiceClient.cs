using System.Threading;
using System.Threading.Tasks;
using STIL.ServiceClient.DTOs.VEU.HentOptagedePladser;
using STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;
using STIL.ServiceClient.DTOs.VEU.HentUdbud;

namespace STIL.ServiceClient;

/// <summary>
/// C# VEU (Voksenuddannelse) Service Client to interact with the SOAP services provided by Styrelsen for IT og Læring (STIL).
/// Link to project documentation:
/// https://github.com/PensionDanmark/STIL.ServiceClient
///
/// Link to STIL service documentation:
/// https://viden.stil.dk/display/OFFintegrationsplatformen/Services.
///
/// <example>
/// using System.Security.Cryptography.X509Certificates;
///
/// // Load your certificate
/// X509Certificate2 certificate = new X509Certificate2("path/to/your/certificate.pfx", "your-password");
///
/// // Create a StilServiceClient instance
/// var stilServiceClient = new StilVeuServiceClient("https://et.integrationsplatformen.dk, certificate);
///
/// // Create a request for the HentTilmeldingerVeuInteressenter method
/// HentTilmeldingerRequest request = new HentTilmeldingerRequest
/// {
///     // ... set the properties of the request
/// };
/// // Call the HentTilmeldingerVeuInteressenter method and get the response
/// var response = await stilServiceClient.VEU.HentTilmeldingerVeuInteressenter(request);
///
/// // Use the response data
/// Console.WriteLine($"Number of tilmeldinger: {result.Message.hentTilmeldingerResponse.Resultat.Resultat.PersonListe.Length}");
/// </example>
/// </summary>
public interface IStilVeuServiceClient
{
    /// <summary>
    /// Hent tilmeldinger VeuInteressenter.
    /// STIL documentation: https://viden.stil.dk/pages/viewpage.action?pageId=121963487.
    /// </summary>
    /// <param name="dataRequest">The data request body.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>An instance of <see cref="hentTilmeldingerResponse"/>.</returns>
    Task<hentTilmeldingerResponse> HentTilmeldingerVeuInteressenter(
        HentTilmeldingerRequest dataRequest, CancellationToken cancellationToken = default);

    /// <summary>
    /// Hent Udbud.
    /// STIL documentation: https://viden.stil.dk/pages/viewpage.action?pageId=121963479.
    /// </summary>
    /// <param name="dataRequest">The data request body.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>An instance of <see cref="HentUdbudResponse"/>.</returns>
    Task<HentUdbudResponse> HentUdbud(HentUdbudRequest dataRequest, CancellationToken cancellationToken = default);

    /// <summary>
    /// Hent optagede pladser.
    /// STIL documentation: https://viden.stil.dk/pages/viewpage.action?pageId=121962771.
    /// </summary>
    /// <param name="dataRequest">The data request body.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>An instance of <see cref="HentOptagedePladserResponse"/>.</returns>
    Task<HentOptagedePladserResponse> HentOptagedePladser(
        HentOptagedePladserRequest dataRequest, CancellationToken cancellationToken = default);
}