namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter;

[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
public class holdplaceringType
{
    private System.DateTime startdatoField;
    private System.DateTime slutdatoField;
    private string tilmeldingstypeField;
    private decimal deltagerprisField;
    private bool deltagerprisFieldSpecified;
    private skolefagHoldplaceringType[] skolefagHoldplaceringListeField;

    /// <summary>
    /// Gets or sets the <see cref="Startdato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 0)]
    public System.DateTime Startdato
    {
        get => startdatoField;
        set => startdatoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Slutdato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 1)]
    public System.DateTime Slutdato
    {
        get => slutdatoField;
        set => slutdatoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Tilmeldingstype"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public string Tilmeldingstype
    {
        get => tilmeldingstypeField;
        set => tilmeldingstypeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Deltagerpris"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public decimal Deltagerpris
    {
        get => deltagerprisField;
        set => deltagerprisField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="DeltagerprisSpecified"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool DeltagerprisSpecified
    {
        get => deltagerprisFieldSpecified;
        set => deltagerprisFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="SkolefagHoldplaceringListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
    [System.Xml.Serialization.XmlArrayItemAttribute("SkolefagHoldplacering",
        Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/skolefagHoldplacering", IsNullable = false)]
    public skolefagHoldplaceringType[] SkolefagHoldplaceringListe
    {
        get => skolefagHoldplaceringListeField;
        set => skolefagHoldplaceringListeField = value;
    }
}