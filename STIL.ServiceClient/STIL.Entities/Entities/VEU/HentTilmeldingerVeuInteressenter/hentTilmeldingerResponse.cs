namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
public class hentTilmeldingerResponse
{
    private Identifier identifierField;

    private string correlationIDField;

    private hentTilmeldingerResponseMessage messageField;

    /// <summary>
    /// Gets or sets the <see cref="Identifier"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public Identifier Identifier
    {
        get => identifierField;
        set => identifierField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="CorrelationID"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string CorrelationID
    {
        get => correlationIDField;
        set => correlationIDField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Message"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public hentTilmeldingerResponseMessage Message
    {
        get => messageField;
        set => messageField = value;
    }
}