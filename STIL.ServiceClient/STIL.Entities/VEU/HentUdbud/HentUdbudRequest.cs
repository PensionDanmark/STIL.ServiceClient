using System;

namespace STIL.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentudbud/v1.0")]
[System.Xml.Serialization.XmlRoot(Namespace = "http://ipl.stil.dk/services/veu/hentudbud/v1.0")]
public class HentUdbudRequest
{
    private Identifier identifierField;
    private HentUdbudRequestMessage messageField;

    /// <summary>
    /// Gets or sets the <see cref="Identifier"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public Identifier Identifier
    {
        get => identifierField;
        set => identifierField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Message"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public HentUdbudRequestMessage Message
    {
        get => messageField;
        set => messageField = value;
    }
}