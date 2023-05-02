namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
public class hentTilmeldingerResponseMessage
{
    private hentTilmeldingerResponse1 hentTilmeldingerResponseField;

    /// <summary>
    /// Gets or sets the <see cref="hentTilmeldingerResponse"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger", Order = 0)]
    public hentTilmeldingerResponse1 hentTilmeldingerResponse
    {
        get => hentTilmeldingerResponseField;
        set => hentTilmeldingerResponseField = value;
    }
}