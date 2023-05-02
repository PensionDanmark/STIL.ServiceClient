using System;

namespace STIL.Entities.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class Opdatering
{
    private long loebenummerField;

    private string aktiGuidField;

    private string instNrField;

    private HandlingType handlingField;

    private Hold holdField;

    /// <summary>
    /// Gets or sets the <see cref="Loebenummer"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public long Loebenummer
    {
        get => loebenummerField;
        set => loebenummerField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="AktiGuid"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string AktiGuid
    {
        get => aktiGuidField;
        set => aktiGuidField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="InstNr"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string InstNr
    {
        get => instNrField;
        set => instNrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Handling"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public HandlingType Handling
    {
        get => handlingField;
        set => handlingField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Hold"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public Hold Hold
    {
        get => holdField;
        set => holdField = value;
    }
}