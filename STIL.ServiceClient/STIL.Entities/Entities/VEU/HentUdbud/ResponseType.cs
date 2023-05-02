using System;

namespace STIL.Entities.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/commontypes")]
public abstract class ResponseType
{
    private ModtagerType modtagerField;

    /// <summary>
    /// Gets or sets the <see cref="Modtager"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public ModtagerType Modtager
    {
        get => modtagerField;
        set => modtagerField = value;
    }
}