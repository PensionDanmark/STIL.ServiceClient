namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The hent tilmeldinger request message class.
/// </summary>
[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
public class HentTilmeldingerRequestMessage
{
    /// <summary>
    /// The hent tilmeldinger field.
    /// </summary>
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