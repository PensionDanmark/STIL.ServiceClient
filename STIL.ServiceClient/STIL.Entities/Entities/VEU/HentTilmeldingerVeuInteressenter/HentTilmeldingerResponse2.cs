namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContract(IsWrapped = false)]
public partial class HentTilmeldingerResponse2
{

    [System.ServiceModel.MessageBodyMember(Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0", Order = 0)]
    public hentTilmeldingerResponse hentTilmeldingerResponse;

    public HentTilmeldingerResponse2()
    {
    }

    public HentTilmeldingerResponse2(hentTilmeldingerResponse hentTilmeldingerResponse)
    {
        this.hentTilmeldingerResponse = hentTilmeldingerResponse;
    }
}