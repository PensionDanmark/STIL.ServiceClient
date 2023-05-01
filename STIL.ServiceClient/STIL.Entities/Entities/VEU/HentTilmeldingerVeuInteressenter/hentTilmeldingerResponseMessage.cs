namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThrough()]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
public partial class hentTilmeldingerResponseMessage
{

    private hentTilmeldingerResponse1 hentTilmeldingerResponseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger", Order = 0)]
    public hentTilmeldingerResponse1 hentTilmeldingerResponse
    {
        get
        {
            return hentTilmeldingerResponseField;
        }
        set
        {
            hentTilmeldingerResponseField = value;
        }
    }
}