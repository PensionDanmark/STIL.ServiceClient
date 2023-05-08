using System.Threading;
using System.Threading.Tasks;
using STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;
using STIL.Entities.Entities.VEU.HentUdbud;

namespace STIL.ServiceClient;

public partial class StilServiceClient
{
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

        /// <summary>
        /// Hent tilmeldinger VeuInteressenter.
        /// STIL documentation: https://viden.stil.dk/pages/viewpage.action?pageId=121963487
        /// </summary>
        /// <param name="dataRequest">The data request body.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An instance of <see cref="hentTilmeldingerResponse"/>.</returns>
        public async Task<hentTilmeldingerResponse> HentTilmeldingerVeuInteressenter(
            HentTilmeldingerRequest dataRequest, CancellationToken cancellationToken = default)
        {
            return await _stilServiceClient.SendSoapRequest<HentTilmeldingerRequest, hentTilmeldingerResponse, STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter.ServiceFaultDetailer>(
                nameof(HentTilmeldingerVeuInteressenter), dataRequest, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Hent Udbud.
        /// STIL documentation: https://viden.stil.dk/pages/viewpage.action?pageId=121963479
        /// </summary>
        /// <param name="dataRequest">The data request body.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An instance of <see cref="Entities.Entities.VEU.HentUdbud.HentUdbudResponse"/>.</returns>
        public async Task<HentUdbudResponse> HentUdbud(HentUdbudRequest dataRequest,
            CancellationToken cancellationToken = default)
        {
            return await _stilServiceClient.SendSoapRequest<HentUdbudRequest, HentUdbudResponse, STIL.Entities.Entities.VEU.HentUdbud.ServiceFaultDetailer>(nameof(HentUdbud),
                dataRequest, cancellationToken: cancellationToken);
        }
    }
}