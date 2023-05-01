namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThrough()]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
public partial class PingResponse
{

    private PingResponseStatus statusField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public PingResponseStatus Status
    {
        get
        {
            return statusField;
        }
        set
        {
            statusField = value;
        }
    }
}