namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The tilmelding type class.
/// </summary>
[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
public class tilmeldingType
{
    /// <summary>
    /// The hopl guid field.
    /// </summary>
    private string hoplGUIDField;

    /// <summary>
    /// The personoplysninger tilmelding field.
    /// </summary>
    private personoplysningerTilmeldingType personoplysningerTilmeldingField;

    /// <summary>
    /// The arbejdsgiver field.
    /// </summary>
    private arbejdsgiverType arbejdsgiverField;

    /// <summary>
    /// The skole field.
    /// </summary>
    private skoleType skoleField;

    /// <summary>
    /// The hold field.
    /// </summary>
    private holdType holdField;

    /// <summary>
    /// The holdplacering field.
    /// </summary>
    private holdplaceringType holdplaceringField;

    /// <summary>
    /// Gets or sets the <see cref="HoplGUID"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string HoplGUID
    {
        get => hoplGUIDField;
        set => hoplGUIDField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="PersonoplysningerTilmelding"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public personoplysningerTilmeldingType PersonoplysningerTilmelding
    {
        get => personoplysningerTilmeldingField;
        set => personoplysningerTilmeldingField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Arbejdsgiver"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public arbejdsgiverType Arbejdsgiver
    {
        get => arbejdsgiverField;
        set => arbejdsgiverField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Skole"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public skoleType Skole
    {
        get => skoleField;
        set => skoleField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Hold"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public holdType Hold
    {
        get => holdField;
        set => holdField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Holdplacering"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public holdplaceringType Holdplacering
    {
        get => holdplaceringField;
        set => holdplaceringField = value;
    }
}