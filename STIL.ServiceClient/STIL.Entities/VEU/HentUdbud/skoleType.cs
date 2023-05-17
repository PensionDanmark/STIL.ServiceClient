using System;

namespace STIL.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class skoleType
{
    private string dsnrField;

    private string navnField;

    /// <summary>
    /// Gets or sets the <see cref="Dsnr"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string Dsnr
    {
        get => dsnrField;
        set => dsnrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Navn"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string Navn
    {
        get => navnField;
        set => navnField = value;
    }
}