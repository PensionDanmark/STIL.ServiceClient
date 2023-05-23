using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The fag plads type class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class fagPladsType
{
    /// <summary>
    /// The dato field.
    /// </summary>
    private DateTime datoField;

    /// <summary>
    /// The antal pladser field.
    /// </summary>
    private decimal antalPladserField;

    /// <summary>
    /// The antal pladser field specified.
    /// </summary>
    private bool antalPladserFieldSpecified;

    /// <summary>
    /// Gets or sets the <see cref="Dato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 0)]
    public DateTime Dato
    {
        get => datoField;
        set => datoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="AntalPladser"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public decimal AntalPladser
    {
        get => antalPladserField;
        set => antalPladserField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="AntalPladserSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool AntalPladserSpecified
    {
        get => antalPladserFieldSpecified;
        set => antalPladserFieldSpecified = value;
    }
}