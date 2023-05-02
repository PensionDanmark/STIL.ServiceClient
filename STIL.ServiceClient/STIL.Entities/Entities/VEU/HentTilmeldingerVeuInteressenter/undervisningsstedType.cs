namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilstededag")]
public class undervisningsstedType
{
    private string navnField;

    private string gadeField;

    private string stedField;

    private string postnummerField;

    private string postdistriktField;

    /// <summary>
    /// Gets or sets the <see cref="Navn"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string Navn
    {
        get => navnField;
        set => navnField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Gade"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string Gade
    {
        get => gadeField;
        set => gadeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Sted"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string Sted
    {
        get => stedField;
        set => stedField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Postnummer"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public string Postnummer
    {
        get => postnummerField;
        set => postnummerField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Postdistrikt"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public string Postdistrikt
    {
        get => postdistriktField;
        set => postdistriktField = value;
    }
}