using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The lokation type class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class lokationType
{
    /// <summary>
    /// The lokation identifikator field.
    /// </summary>
    private string lokationIdentifikatorField;

    /// <summary>
    /// The betegnelse field.
    /// </summary>
    private string betegnelseField;

    /// <summary>
    /// The gade field.
    /// </summary>
    private string gadeField;

    /// <summary>
    /// The sted field.
    /// </summary>
    private string stedField;

    /// <summary>
    /// The post nr field.
    /// </summary>
    private string postNrField;

    /// <summary>
    /// The kommunekode field.
    /// </summary>
    private string kommunekodeField;

    /// <summary>
    /// The telefonnummer field.
    /// </summary>
    private string telefonnummerField;

    /// <summary>
    /// Gets or sets the <see cref="LokationIdentifikator"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string LokationIdentifikator
    {
        get => lokationIdentifikatorField;
        set => lokationIdentifikatorField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Betegnelse"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string Betegnelse
    {
        get => betegnelseField;
        set => betegnelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Gade"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string Gade
    {
        get => gadeField;
        set => gadeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Sted"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public string Sted
    {
        get => stedField;
        set => stedField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="PostNr"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public string PostNr
    {
        get => postNrField;
        set => postNrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Kommunekode"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public string Kommunekode
    {
        get => kommunekodeField;
        set => kommunekodeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Telefonnummer"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
    public string Telefonnummer
    {
        get => telefonnummerField;
        set => telefonnummerField = value;
    }
}