using System;

namespace STIL.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class fagPeriodeType
{
    private DateTime startDatoField;
    private DateTime slutDatoField;
    private decimal varighedDageField;
    private bool varighedDageFieldSpecified;
    private enumJN foregarUndervisningPaVirkField;
    private bool foregarUndervisningPaVirkFieldSpecified;
    private enumJN fjernundervisningField;
    private bool fjernundervisningFieldSpecified;
    private lokationType lokationField;

    /// <summary>
    /// Gets or sets the <see cref="StartDato"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 0)]
    public DateTime StartDato
    {
        get => startDatoField;
        set => startDatoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="SlutDato"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 1)]
    public DateTime SlutDato
    {
        get => slutDatoField;
        set => slutDatoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="VarighedDage"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public decimal VarighedDage
    {
        get => varighedDageField;
        set => varighedDageField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="VarighedDageSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool VarighedDageSpecified
    {
        get => varighedDageFieldSpecified;
        set => varighedDageFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ForegarUndervisningPaVirk"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public enumJN ForegarUndervisningPaVirk
    {
        get => foregarUndervisningPaVirkField;
        set => foregarUndervisningPaVirkField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ForegarUndervisningPaVirkSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool ForegarUndervisningPaVirkSpecified
    {
        get => foregarUndervisningPaVirkFieldSpecified;
        set => foregarUndervisningPaVirkFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Fjernundervisning"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public enumJN Fjernundervisning
    {
        get => fjernundervisningField;
        set => fjernundervisningField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="FjernundervisningSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool FjernundervisningSpecified
    {
        get => fjernundervisningFieldSpecified;
        set => fjernundervisningFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Lokation"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public lokationType Lokation
    {
        get => lokationField;
        set => lokationField = value;
    }
}