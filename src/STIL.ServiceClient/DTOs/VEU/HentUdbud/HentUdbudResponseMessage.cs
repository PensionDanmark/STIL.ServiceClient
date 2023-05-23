using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The hent udbud response message class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentudbud/v1.0")]
public class HentUdbudResponseMessage
{
    /// <summary>
    /// The hent udbud response field.
    /// </summary>
    private HentUdbudResponse1 hentUdbudResponseField;

    /// <summary>
    /// Gets or sets the <see cref="HentUdbudResponse"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud", Order = 0)]
    public HentUdbudResponse1 HentUdbudResponse
    {
        get => hentUdbudResponseField;
        set => hentUdbudResponseField = value;
    }
}