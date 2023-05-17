namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
public class personType
{
    private string cPRnummerField;
    private string statusCPRnummerField;
    private tilmeldingType[] tilmeldingsListeField;

    /// <summary>
    /// Gets or sets the <see cref="CPRnummer"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string CPRnummer
    {
        get => cPRnummerField;
        set => cPRnummerField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="StatusCPRnummer"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string StatusCPRnummer
    {
        get => statusCPRnummerField;
        set => statusCPRnummerField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TilmeldingsListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Tilmelding",
        Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding", IsNullable = false)]
    public tilmeldingType[] TilmeldingsListe
    {
        get => tilmeldingsListeField;
        set => tilmeldingsListeField = value;
    }
}