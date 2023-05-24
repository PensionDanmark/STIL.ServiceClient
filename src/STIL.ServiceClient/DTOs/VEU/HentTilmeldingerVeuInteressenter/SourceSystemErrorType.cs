namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The source system error type class.
/// </summary>
[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
public class SourceSystemErrorType
{
    /// <summary>
    /// The source system name field.
    /// </summary>
    private string sourceSystemNameField;

    /// <summary>
    /// The error code field.
    /// </summary>
    private string errorCodeField;

    /// <summary>
    /// The details field.
    /// </summary>
    private string detailsField;

    /// <summary>
    /// Gets or sets the <see cref="SourceSystemName"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string SourceSystemName
    {
        get => sourceSystemNameField;
        set => sourceSystemNameField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ErrorCode"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string ErrorCode
    {
        get => errorCodeField;
        set => errorCodeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Details"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string Details
    {
        get => detailsField;
        set => detailsField = value;
    }
}