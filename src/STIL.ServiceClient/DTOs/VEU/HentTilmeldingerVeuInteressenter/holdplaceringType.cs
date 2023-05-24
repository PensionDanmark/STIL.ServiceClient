namespace STIL.ServiceClient.DTOs.VEU.HentTilmeldingerVeuInteressenter;

/// <summary>
/// The holdplacering type class.
/// </summary>
[System.SerializableAttribute]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
public class holdplaceringType
{
    /// <summary>
    /// The startdato field.
    /// </summary>
    private System.DateTime startdatoField;

    /// <summary>
    /// The slutdato field.
    /// </summary>
    private System.DateTime slutdatoField;

    /// <summary>
    /// The tilmeldingstype field.
    /// </summary>
    private string tilmeldingstypeField;

    /// <summary>
    /// The deltagerpris field.
    /// </summary>
    private decimal deltagerprisField;

    /// <summary>
    /// The deltagerpris field specified.
    /// </summary>
    private bool deltagerprisFieldSpecified;

    /// <summary>
    /// The skolefag holdplacering liste field.
    /// </summary>
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
    /// Gets or sets a value indicating whether <see cref="DeltagerprisSpecified"/> value is set.
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
    [System.Xml.Serialization.XmlArrayItemAttribute("SkolefagHoldplacering", Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/skolefagHoldplacering", IsNullable = false)]
    public skolefagHoldplaceringType[] SkolefagHoldplaceringListe
    {
        get => skolefagHoldplaceringListeField;
        set => skolefagHoldplaceringListeField = value;
    }
}