namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The hent tilmeldinger request class.
/// </summary>
[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
public class hentTilmeldingerRequest
{
    /// <summary>
    /// The indhold field.
    /// </summary>
    private hentTilmeldingerReqIndhold indholdField;

    /// <summary>
    /// Gets or sets the <see cref="Indhold"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public hentTilmeldingerReqIndhold Indhold
    {
        get => indholdField;
        set => indholdField = value;
    }
}