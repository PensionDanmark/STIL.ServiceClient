namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The skolefag holdplacering type class.
/// </summary>
[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/skolefagHoldplacering")]
public class skolefagHoldplaceringType
{
    /// <summary>
    /// The skolefag field.
    /// </summary>
    private skolefagType skolefagField;

    /// <summary>
    /// The startdato field.
    /// </summary>
    private System.DateTime startdatoField;

    /// <summary>
    /// The slutdato field.
    /// </summary>
    private System.DateTime slutdatoField;

    /// <summary>
    /// The slutdato field specified.
    /// </summary>
    private bool slutdatoFieldSpecified;

    /// <summary>
    /// The gennemfort field.
    /// </summary>
    private string gennemfortField;

    /// <summary>
    /// The fjernundervisning field.
    /// </summary>
    private enumJN fjernundervisningField;

    /// <summary>
    /// The fjernundervisning field specified.
    /// </summary>
    private bool fjernundervisningFieldSpecified;

    /// <summary>
    /// The foregar undervisning paa virk field.
    /// </summary>
    private enumJN foregarUndervisningPaaVirkField;

    /// <summary>
    /// The foregar undervisning paa virk field specified.
    /// </summary>
    private bool foregarUndervisningPaaVirkFieldSpecified;

    /// <summary>
    /// The certifikatkursus field.
    /// </summary>
    private enumJN certifikatkursusField;

    /// <summary>
    /// The certifikatkursus field specified.
    /// </summary>
    private bool certifikatkursusFieldSpecified;

    /// <summary>
    /// The varighed dage field.
    /// </summary>
    private decimal varighedDageField;

    /// <summary>
    /// The varighed dage field specified.
    /// </summary>
    private bool varighedDageFieldSpecified;

    /// <summary>
    /// The normeret varighed field.
    /// </summary>
    private decimal normeretVarighedField;

    /// <summary>
    /// The normeret varighed field specified.
    /// </summary>
    private bool normeretVarighedFieldSpecified;

    /// <summary>
    /// The tilstededag liste field.
    /// </summary>
    private tilstededagType[] tilstededagListeField;

    /// <summary>
    /// Gets or sets the <see cref="Skolefag"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public skolefagType Skolefag
    {
        get => skolefagField;
        set => skolefagField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Startdato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 1)]
    public System.DateTime Startdato
    {
        get => startdatoField;
        set => startdatoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Slutdato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 2)]
    public System.DateTime Slutdato
    {
        get => slutdatoField;
        set => slutdatoField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="SlutdatoSpecified"/> value is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool SlutdatoSpecified
    {
        get => slutdatoFieldSpecified;
        set => slutdatoFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Gennemfort"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public string Gennemfort
    {
        get => gennemfortField;
        set => gennemfortField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Fjernundervisning"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public enumJN Fjernundervisning
    {
        get => fjernundervisningField;
        set => fjernundervisningField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="FjernundervisningSpecified"/> value is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool FjernundervisningSpecified
    {
        get => fjernundervisningFieldSpecified;
        set => fjernundervisningFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ForegarUndervisningPaaVirk"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public enumJN ForegarUndervisningPaaVirk
    {
        get => foregarUndervisningPaaVirkField;
        set => foregarUndervisningPaaVirkField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="ForegarUndervisningPaaVirkSpecified"/> value is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool ForegarUndervisningPaaVirkSpecified
    {
        get => foregarUndervisningPaaVirkFieldSpecified;
        set => foregarUndervisningPaaVirkFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Certifikatkursus"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
    public enumJN Certifikatkursus
    {
        get => certifikatkursusField;
        set => certifikatkursusField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="CertifikatkursusSpecified"/> value is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool CertifikatkursusSpecified
    {
        get => certifikatkursusFieldSpecified;
        set => certifikatkursusFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="VarighedDage"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
    public decimal VarighedDage
    {
        get => varighedDageField;
        set => varighedDageField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="VarighedDageSpecified"/> value is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool VarighedDageSpecified
    {
        get => varighedDageFieldSpecified;
        set => varighedDageFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="NormeretVarighed"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
    public decimal NormeretVarighed
    {
        get => normeretVarighedField;
        set => normeretVarighedField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="NormeretVarighedSpecified"/> value is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool NormeretVarighedSpecified
    {
        get => normeretVarighedFieldSpecified;
        set => normeretVarighedFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TilstededagListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order = 9)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Tilstededag", Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilstededag", IsNullable = false)]
    public tilstededagType[] TilstededagListe
    {
        get => tilstededagListeField;
        set => tilstededagListeField = value;
    }
}