namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
public class hentTilmeldinger
{
    private wsSyncReqModtagerV2 wsSyncReqModtagerV2Field;

    private hentTilmeldingerRequest beskedField;

    /// <summary>
    /// Gets or sets the <see cref="wsSyncReqModtagerV2"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public wsSyncReqModtagerV2 wsSyncReqModtagerV2
    {
        get => wsSyncReqModtagerV2Field;
        set => wsSyncReqModtagerV2Field = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Besked"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public hentTilmeldingerRequest Besked
    {
        get => beskedField;
        set => beskedField = value;
    }
}