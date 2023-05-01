namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/common")]
public class wsSyncReqModtagerV2
{
    private string modtagerSystemIDField;

    private string modtagerSystemTransaktionsIDField;

    /// <summary>
    /// Gets or sets the <see cref="ModtagerSystemID"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string ModtagerSystemID
    {
        get => modtagerSystemIDField;
        set => modtagerSystemIDField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ModtagerSystemTransaktionsID"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string ModtagerSystemTransaktionsID
    {
        get => modtagerSystemTransaktionsIDField;
        set => modtagerSystemTransaktionsIDField = value;
    }
}