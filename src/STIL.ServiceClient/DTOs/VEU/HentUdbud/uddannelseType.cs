using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The uddannelse type class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class uddannelseType
{
    /// <summary>
    /// The os aformal field.
    /// </summary>
    private string cOSAformalField;

    /// <summary>
    /// The version field.
    /// </summary>
    private string versionField;

    /// <summary>
    /// The betegnelse field.
    /// </summary>
    private string betegnelseField;

    /// <summary>
    /// The uddannelsestype field.
    /// </summary>
    private UddannelsestypeType uddannelsestypeField;

    /// <summary>
    /// The uddannelsestype field specified.
    /// </summary>
    private bool uddannelsestypeFieldSpecified;

    /// <summary>
    /// Gets or sets the <see cref="COSAformal"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string COSAformal
    {
        get => cOSAformalField;
        set => cOSAformalField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Version"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string Version
    {
        get => versionField;
        set => versionField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Betegnelse"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string Betegnelse
    {
        get => betegnelseField;
        set => betegnelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Uddannelsestype"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public UddannelsestypeType Uddannelsestype
    {
        get => uddannelsestypeField;
        set => uddannelsestypeField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether the <see cref="UddannelsestypeSpecified"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool UddannelsestypeSpecified
    {
        get => uddannelsestypeFieldSpecified;
        set => uddannelsestypeFieldSpecified = value;
    }
}