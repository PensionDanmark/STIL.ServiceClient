namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
public class hentTilmeldingerRequest
{
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