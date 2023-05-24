using System.Xml.Serialization;

namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The hent tilmeldinger request class.
/// </summary>
[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
[XmlRoot(Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
public class HentTilmeldingerRequest
{
    /// <summary>
    /// The identifier field.
    /// </summary>
    private Identifier identifierField;

    /// <summary>
    /// The message field.
    /// </summary>
    private HentTilmeldingerRequestMessage messageField;

    /// <summary>
    /// Gets or sets the <see cref="Identifier"/> value.
    /// </summary>
    [XmlElement(Order = 0)]
    public Identifier Identifier
    {
        get => identifierField;
        set => identifierField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Message"/> value.
    /// </summary>
    [XmlElement(Order = 1)]
    public HentTilmeldingerRequestMessage Message
    {
        get => messageField;
        set => messageField = value;
    }
}