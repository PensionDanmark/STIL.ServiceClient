using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The fag periode type class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class fagPeriodeType
{
    /// <summary>
    /// The start dato field.
    /// </summary>
    private DateTime startDatoField;

    /// <summary>
    /// The slut dato field.
    /// </summary>
    private DateTime slutDatoField;

    /// <summary>
    /// The varighed dage field.
    /// </summary>
    private decimal varighedDageField;

    /// <summary>
    /// The varighed dage field specified.
    /// </summary>
    private bool varighedDageFieldSpecified;

    /// <summary>
    /// The foregar undervisning pa virk field.
    /// </summary>
    private enumJN foregarUndervisningPaVirkField;

    /// <summary>
    /// The foregar undervisning pa virk field specified.
    /// </summary>
    private bool foregarUndervisningPaVirkFieldSpecified;

    /// <summary>
    /// The fjernundervisning field.
    /// </summary>
    private enumJN fjernundervisningField;

    /// <summary>
    /// The fjernundervisning field specified.
    /// </summary>
    private bool fjernundervisningFieldSpecified;

    /// <summary>
    /// The lokation field.
    /// </summary>
    private lokationType lokationField;

    /// <summary>
    /// Gets or sets the <see cref="StartDato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 0)]
    public DateTime StartDato
    {
        get => startDatoField;
        set => startDatoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="SlutDato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 1)]
    public DateTime SlutDato
    {
        get => slutDatoField;
        set => slutDatoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="VarighedDage"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public decimal VarighedDage
    {
        get => varighedDageField;
        set => varighedDageField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="VarighedDageSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool VarighedDageSpecified
    {
        get => varighedDageFieldSpecified;
        set => varighedDageFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ForegarUndervisningPaVirk"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public enumJN ForegarUndervisningPaVirk
    {
        get => foregarUndervisningPaVirkField;
        set => foregarUndervisningPaVirkField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="ForegarUndervisningPaVirkSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool ForegarUndervisningPaVirkSpecified
    {
        get => foregarUndervisningPaVirkFieldSpecified;
        set => foregarUndervisningPaVirkFieldSpecified = value;
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
    /// Gets or sets a value indicating whether <see cref="FjernundervisningSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool FjernundervisningSpecified
    {
        get => fjernundervisningFieldSpecified;
        set => fjernundervisningFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Lokation"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public lokationType Lokation
    {
        get => lokationField;
        set => lokationField = value;
    }
}