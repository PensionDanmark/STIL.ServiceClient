using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The hent udbud request class.
/// </summary>
/// <seealso cref="RequestType"/>
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class HentUdbudRequest1 : RequestType
{
    /// <summary>
    /// The indhold field.
    /// </summary>
    private IndholdRequestType indholdField;

    /// <summary>
    /// Gets or sets the <see cref="Indhold"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public IndholdRequestType Indhold
    {
        get => indholdField;
        set => indholdField = value;
    }
}