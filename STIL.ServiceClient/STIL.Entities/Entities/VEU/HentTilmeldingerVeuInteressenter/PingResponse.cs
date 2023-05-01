namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
public class PingResponse
{
        
    private PingResponseStatus statusField;

    /// <summary>
    /// Gets or sets the <see cref="Status"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public PingResponseStatus Status {
        get => statusField;
        set => statusField = value;
    }
}