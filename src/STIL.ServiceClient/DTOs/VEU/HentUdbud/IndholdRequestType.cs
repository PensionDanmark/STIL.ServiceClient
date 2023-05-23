using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The indhold request type class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class IndholdRequestType
{
    /// <summary>
    /// The ds nummer liste field.
    /// </summary>
    private string[] dsNummerListeField;

    /// <summary>
    /// The nyere end loebenummer field.
    /// </summary>
    private long nyereEndLoebenummerField;

    /// <summary>
    /// The nyere end loebenummer field specified.
    /// </summary>
    private bool nyereEndLoebenummerFieldSpecified;

    /// <summary>
    /// Gets or sets the <see cref="DsNummerListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("DsNummerListe", Order = 0)]
    public string[] DsNummerListe
    {
        get => dsNummerListeField;
        set => dsNummerListeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="NyereEndLoebenummer"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public long NyereEndLoebenummer
    {
        get => nyereEndLoebenummerField;
        set => nyereEndLoebenummerField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="NyereEndLoebenummerSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool NyereEndLoebenummerSpecified
    {
        get => nyereEndLoebenummerFieldSpecified;
        set => nyereEndLoebenummerFieldSpecified = value;
    }
}