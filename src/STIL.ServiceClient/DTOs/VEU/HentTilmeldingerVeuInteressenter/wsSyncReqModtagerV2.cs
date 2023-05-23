namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The ws sync req modtager class.
/// </summary>
[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/common")]
public class wsSyncReqModtagerV2
{
    /// <summary>
    /// The modtager system id field.
    /// </summary>
    private string modtagerSystemIDField;

    /// <summary>
    /// The modtager system transaktions id field.
    /// </summary>
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