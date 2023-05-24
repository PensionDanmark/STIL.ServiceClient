using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The opdatering class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class Opdatering
{
    /// <summary>
    /// The loebenummer field.
    /// </summary>
    private long loebenummerField;

    /// <summary>
    /// The akti guid field.
    /// </summary>
    private string aktiGuidField;

    /// <summary>
    /// The inst nr field.
    /// </summary>
    private string instNrField;

    /// <summary>
    /// The handling field.
    /// </summary>
    private HandlingType handlingField;

    /// <summary>
    /// The hold field.
    /// </summary>
    private Hold holdField;

    /// <summary>
    /// Gets or sets the <see cref="Loebenummer"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public long Loebenummer
    {
        get => loebenummerField;
        set => loebenummerField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="AktiGuid"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string AktiGuid
    {
        get => aktiGuidField;
        set => aktiGuidField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="InstNr"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string InstNr
    {
        get => instNrField;
        set => instNrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Handling"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public HandlingType Handling
    {
        get => handlingField;
        set => handlingField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Hold"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public Hold Hold
    {
        get => holdField;
        set => holdField = value;
    }
}