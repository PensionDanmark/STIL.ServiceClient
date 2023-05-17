using System;

namespace STIL.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class UVMfagType
{
    private string uVMfagKodeField;

    private string niveauField;

    private string betegnelseField;

    /// <summary>
    /// Gets or sets the <see cref="UVMfagKode"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string UVMfagKode
    {
        get => uVMfagKodeField;
        set => uVMfagKodeField = value;
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

    /// <summary>
    /// Gets or sets the <see cref="Betegnelse"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string Betegnelse
    {
        get => betegnelseField;
        set => betegnelseField = value;
    }
}