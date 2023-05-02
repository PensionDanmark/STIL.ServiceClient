using System;

namespace STIL.Entities.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class skolefagType
{
    private string skolefagKodeField;

    private string niveauField;

    /// <summary>
    /// Gets or sets the <see cref="SkolefagKode"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string SkolefagKode
    {
        get => skolefagKodeField;
        set => skolefagKodeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Niveau"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string Niveau
    {
        get => niveauField;
        set => niveauField = value;
    }
}