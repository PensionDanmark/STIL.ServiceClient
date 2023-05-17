namespace STIL.Entities.VEU.HentOptagedePladser;

[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
public class ServiceFaultDetailer
{
    private string correlationIDField;
    private System.DateTime timestampField;
    private string errorCodeField;
    private string errorMessageField;
    private string detailsField;
    private SourceSystemErrorType sourceSystemErrorField;

    /// <summary>
    /// Gets or sets the <see cref="CorrelationID"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string CorrelationID
    {
        get => correlationIDField;
        set => correlationIDField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Timestamp"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public System.DateTime Timestamp
    {
        get => timestampField;
        set => timestampField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ErrorCode"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string ErrorCode
    {
        get => errorCodeField;
        set => errorCodeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ErrorMessage"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public string ErrorMessage
    {
        get => errorMessageField;
        set => errorMessageField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Details"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public string Details
    {
        get => detailsField;
        set => detailsField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="SourceSystemError"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public SourceSystemErrorType SourceSystemError
    {
        get => sourceSystemErrorField;
        set => sourceSystemErrorField = value;
    }
}