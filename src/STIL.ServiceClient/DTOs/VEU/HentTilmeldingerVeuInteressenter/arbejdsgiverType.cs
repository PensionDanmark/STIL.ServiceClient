namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The arbejdsgiver type class.
/// </summary>
[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
public class arbejdsgiverType
{
    /// <summary>
    /// The rnr field.
    /// </summary>
    private string cVRnrField;

    /// <summary>
    /// The pnummer field.
    /// </summary>
    private string pnummerField;

    /// <summary>
    /// The navn field.
    /// </summary>
    private string navnField;

    /// <summary>
    /// The email field.
    /// </summary>
    private string emailField;

    /// <summary>
    /// Gets or sets the <see cref="CVRnr"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string CVRnr
    {
        get => cVRnrField;
        set => cVRnrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Pnummer"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string Pnummer
    {
        get => pnummerField;
        set => pnummerField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Navn"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string Navn
    {
        get => navnField;
        set => navnField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Email"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public string Email
    {
        get => emailField;
        set => emailField = value;
    }
}