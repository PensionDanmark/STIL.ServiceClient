using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The skolefag type class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class skolefagType
{
    /// <summary>
    /// The skolefag kode field.
    /// </summary>
    private string skolefagKodeField;

    /// <summary>
    /// The niveau field.
    /// </summary>
    private string niveauField;

    /// <summary>
    /// Gets or sets the <see cref="SkolefagKode"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string SkolefagKode
    {
        get => skolefagKodeField;
        set => skolefagKodeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Niveau"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string Niveau
    {
        get => niveauField;
        set => niveauField = value;
    }
}