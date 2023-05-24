namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The skole type class.
/// </summary>
[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
public class skoleType
{
    /// <summary>
    /// The snr field.
    /// </summary>
    private string dSnrField;

    /// <summary>
    /// The navn field.
    /// </summary>
    private string navnField;

    /// <summary>
    /// Gets or sets the <see cref="DSnr"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string DSnr
    {
        get => dSnrField;
        set => dSnrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Navn"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string Navn
    {
        get => navnField;
        set => navnField = value;
    }
}