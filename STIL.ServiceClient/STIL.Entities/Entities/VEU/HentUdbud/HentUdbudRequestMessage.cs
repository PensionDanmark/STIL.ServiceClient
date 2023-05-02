using System;

namespace STIL.Entities.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentudbud/v1.0")]
public class HentUdbudRequestMessage
{
    private HentUdbudRequest1 hentUdbudRequestField;

    /// <summary>
    /// Gets or sets the <see cref="HentUdbudRequest"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud", Order = 0)]
    public HentUdbudRequest1 HentUdbudRequest
    {
        get => hentUdbudRequestField;
        set => hentUdbudRequestField = value;
    }
}