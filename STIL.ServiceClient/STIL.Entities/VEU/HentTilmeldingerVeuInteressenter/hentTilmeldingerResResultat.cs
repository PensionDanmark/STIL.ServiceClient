namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
public class hentTilmeldingerResResultat
{
    private string instNrField;

    private string svarKodeField;

    private string svarTekstField;

    private personType[] personListeField;

    /// <summary>
    /// Gets or sets the <see cref="InstNr"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string InstNr
    {
        get => instNrField;
        set => instNrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="SvarKode"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string SvarKode
    {
        get => svarKodeField;
        set => svarKodeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="SvarTekst"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string SvarTekst
    {
        get => svarTekstField;
        set => svarTekstField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="PersonListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Person", IsNullable = false)]
    public personType[] PersonListe
    {
        get => personListeField;
        set => personListeField = value;
    }
}