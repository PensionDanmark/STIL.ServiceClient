namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContract(IsWrapped = false)]
public partial class PingResponse1
{

    [System.ServiceModel.MessageBodyMember(Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0", Order = 0)]
    public PingResponse PingResponse;

    public PingResponse1()
    {
    }

    public PingResponse1(PingResponse PingResponse)
    {
        this.PingResponse = PingResponse;
    }
}