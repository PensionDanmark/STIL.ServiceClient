using System;

namespace STIL.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class lokationType
{
    private string lokationIdentifikatorField;
    private string betegnelseField;
    private string gadeField;
    private string stedField;
    private string postNrField;
    private string kommunekodeField;
    private string telefonnummerField;

    /// <summary>
    /// Gets or sets the <see cref="LokationIdentifikator"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string LokationIdentifikator
    {
        get => lokationIdentifikatorField;
        set => lokationIdentifikatorField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Betegnelse"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string Betegnelse
    {
        get => betegnelseField;
        set => betegnelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Gade"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string Gade
    {
        get => gadeField;
        set => gadeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Sted"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public string Sted
    {
        get => stedField;
        set => stedField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="PostNr"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public string PostNr
    {
        get => postNrField;
        set => postNrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Kommunekode"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public string Kommunekode
    {
        get => kommunekodeField;
        set => kommunekodeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Telefonnummer"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
    public string Telefonnummer
    {
        get => telefonnummerField;
        set => telefonnummerField = value;
    }
}