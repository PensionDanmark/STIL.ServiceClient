namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The hent tilmeldinger response message class.
/// </summary>
[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
public class hentTilmeldingerResponseMessage
{
    /// <summary>
    /// The hent tilmeldinger response field.
    /// </summary>
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