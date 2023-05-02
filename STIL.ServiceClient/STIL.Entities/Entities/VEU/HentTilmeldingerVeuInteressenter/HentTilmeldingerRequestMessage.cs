namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
public class HentTilmeldingerRequestMessage
{
    private hentTilmeldinger hentTilmeldingerField;

    /// <summary>
    /// Gets or sets the <see cref="hentTilmeldinger"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger", Order = 0)]
    public hentTilmeldinger hentTilmeldinger
    {
        get => hentTilmeldingerField;
        set => hentTilmeldingerField = value;
    }
}