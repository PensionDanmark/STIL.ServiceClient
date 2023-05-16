using System;

namespace STIL.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class tillegsprisType
{
    private decimal tillegsprisField;

    private bool tillegsprisFieldSpecified;

    private string tillegsprisArsagField;

    private enumJN finanslovFastsatField;

    /// <summary>
    /// Gets or sets the <see cref="Tillegspris"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public decimal Tillegspris
    {
        get => tillegsprisField;
        set => tillegsprisField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TillegsprisSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool TillegsprisSpecified
    {
        get => tillegsprisFieldSpecified;
        set => tillegsprisFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TillegsprisArsag"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public string TillegsprisArsag
    {
        get => tillegsprisArsagField;
        set => tillegsprisArsagField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="FinanslovFastsat"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public enumJN FinanslovFastsat
    {
        get => finanslovFastsatField;
        set => finanslovFastsatField = value;
    }
}