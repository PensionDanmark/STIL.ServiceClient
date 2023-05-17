using System;

namespace STIL.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class holdPladsType
{
    private DateTime datoField;
    private decimal antalPladserField;
    private bool antalPladserFieldSpecified;

    /// <summary>
    /// Gets or sets the <see cref="Dato"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 0)]
    public DateTime Dato
    {
        get => datoField;
        set => datoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="AntalPladser"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public decimal AntalPladser
    {
        get => antalPladserField;
        set => antalPladserField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="AntalPladserSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool AntalPladserSpecified
    {
        get => antalPladserFieldSpecified;
        set => antalPladserFieldSpecified = value;
    }
}