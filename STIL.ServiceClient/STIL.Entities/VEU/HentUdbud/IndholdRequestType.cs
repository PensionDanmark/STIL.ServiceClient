using System;

namespace STIL.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class IndholdRequestType
{
    private string[] dsNummerListeField;
    private long nyereEndLoebenummerField;
    private bool nyereEndLoebenummerFieldSpecified;

    /// <summary>
    /// Gets or sets the <see cref="DsNummerListe"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("DsNummerListe", Order = 0)]
    public string[] DsNummerListe
    {
        get => dsNummerListeField;
        set => dsNummerListeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="NyereEndLoebenummer"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public long NyereEndLoebenummer
    {
        get => nyereEndLoebenummerField;
        set => nyereEndLoebenummerField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="NyereEndLoebenummerSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool NyereEndLoebenummerSpecified
    {
        get => nyereEndLoebenummerFieldSpecified;
        set => nyereEndLoebenummerFieldSpecified = value;
    }
}