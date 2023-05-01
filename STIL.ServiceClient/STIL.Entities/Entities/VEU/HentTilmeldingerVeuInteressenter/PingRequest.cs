namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContract(IsWrapped = false)]
public partial class PingRequest
{

    [System.ServiceModel.MessageBodyMember(Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0", Order = 0)]
    public Ping Ping;

    public PingRequest()
    {
    }

    public PingRequest(Ping Ping)
    {
        this.Ping = Ping;
    }
}