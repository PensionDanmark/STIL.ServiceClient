using System;

namespace STIL.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class Hold
{
    private string aktiGuidField;
    private DateTime startdatoField;
    private DateTime slutdatoField;
    private string kortBetegnelseField;
    private string betegnelseField;
    private string beskrivelseField;
    private string uGNavnField;
    private decimal antalPladserField;
    private bool antalPladserFieldSpecified;
    private decimal elevLektionerField;
    private bool elevLektionerFieldSpecified;
    private enumJN aflystField;
    private DateTime aflystPrdatoField;
    private bool aflystPrdatoFieldSpecified;
    private string undervisningstidField;
    private UndervisningsformType undervisningsformField;
    private bool undervisningsformFieldSpecified;
    private DateTime tilmeldingsfristField;
    private IndberetningsprincipType indberetningsprincipField;
    private enumJN lastField;
    private string forudsaetningerField;
    private string kviknrField;
    private string kontaktpersonField;
    private string kontaktTelefonnrField;
    private string emailField;
    private string hjemmesideField;
    private string aktivitetsafdelingField;
    private string projektomradeField;
    private string ansvarsomradeField;
    private decimal minimumAntalTilmeldteField;
    private bool minimumAntalTilmeldteFieldSpecified;
    private enumJN kontraktuddannelseField;
    private enumJN garantiKursusField;
    private decimal deltagerPrisBeloebField;
    private bool deltagerPrisBeloebFieldSpecified;
    private skoleType skoleField;
    private lokationType lokationField;
    private uddannelseType uddannelseField;
    private holdPladsType[] holdPladsListeField;
    private tillegsprisType[] tillegsprisListeField;
    private skolefagPaHoldType[] skolefagPaHoldListeField;

    /// <summary>
    /// Gets or sets the <see cref="AktiGuid"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string AktiGuid
    {
        get => aktiGuidField;
        set => aktiGuidField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Startdato"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 1)]
    public DateTime Startdato
    {
        get => startdatoField;
        set => startdatoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Slutdato"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 2)]
    public DateTime Slutdato
    {
        get => slutdatoField;
        set => slutdatoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="KortBetegnelse"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public string KortBetegnelse
    {
        get => kortBetegnelseField;
        set => kortBetegnelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Betegnelse"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public string Betegnelse
    {
        get => betegnelseField;
        set => betegnelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Beskrivelse"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public string Beskrivelse
    {
        get => beskrivelseField;
        set => beskrivelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="UGNavn"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
    public string UGNavn
    {
        get => uGNavnField;
        set => uGNavnField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="AntalPladser"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
    public decimal AntalPladser
    {
        get => antalPladserField;
        set => antalPladserField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="AntalPladserSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool AntalPladserSpecified
    {
        get => antalPladserFieldSpecified;
        set => antalPladserFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ElevLektioner"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
    public decimal ElevLektioner
    {
        get => elevLektionerField;
        set => elevLektionerField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ElevLektionerSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool ElevLektionerSpecified
    {
        get => elevLektionerFieldSpecified;
        set => elevLektionerFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Aflyst"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
    public enumJN Aflyst
    {
        get => aflystField;
        set => aflystField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="AflystPrdato"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 10)]
    public DateTime AflystPrdato
    {
        get => aflystPrdatoField;
        set => aflystPrdatoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="AflystPrdatoSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool AflystPrdatoSpecified
    {
        get => aflystPrdatoFieldSpecified;
        set => aflystPrdatoFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Undervisningstid"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
    public string Undervisningstid
    {
        get => undervisningstidField;
        set => undervisningstidField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Undervisningsform"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
    public UndervisningsformType Undervisningsform
    {
        get => undervisningsformField;
        set => undervisningsformField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="UndervisningsformSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool UndervisningsformSpecified
    {
        get => undervisningsformFieldSpecified;
        set => undervisningsformFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Tilmeldingsfrist"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 13)]
    public DateTime Tilmeldingsfrist
    {
        get => tilmeldingsfristField;
        set => tilmeldingsfristField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Indberetningsprincip"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
    public IndberetningsprincipType Indberetningsprincip
    {
        get => indberetningsprincipField;
        set => indberetningsprincipField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Last"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
    public enumJN Last
    {
        get => lastField;
        set => lastField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Forudsaetninger"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
    public string Forudsaetninger
    {
        get => forudsaetningerField;
        set => forudsaetningerField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Kviknr"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
    public string Kviknr
    {
        get => kviknrField;
        set => kviknrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Kontaktperson"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
    public string Kontaktperson
    {
        get => kontaktpersonField;
        set => kontaktpersonField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="KontaktTelefonnr"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
    public string KontaktTelefonnr
    {
        get => kontaktTelefonnrField;
        set => kontaktTelefonnrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Email"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
    public string Email
    {
        get => emailField;
        set => emailField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Hjemmeside"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
    public string Hjemmeside
    {
        get => hjemmesideField;
        set => hjemmesideField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Aktivitetsafdeling"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
    public string Aktivitetsafdeling
    {
        get => aktivitetsafdelingField;
        set => aktivitetsafdelingField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Projektomrade"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
    public string Projektomrade
    {
        get => projektomradeField;
        set => projektomradeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Ansvarsomrade"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
    public string Ansvarsomrade
    {
        get => ansvarsomradeField;
        set => ansvarsomradeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="MinimumAntalTilmeldte"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 25)]
    public decimal MinimumAntalTilmeldte
    {
        get => minimumAntalTilmeldteField;
        set => minimumAntalTilmeldteField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="MinimumAntalTilmeldteSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool MinimumAntalTilmeldteSpecified
    {
        get => minimumAntalTilmeldteFieldSpecified;
        set => minimumAntalTilmeldteFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Kontraktuddannelse"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 26)]
    public enumJN Kontraktuddannelse
    {
        get => kontraktuddannelseField;
        set => kontraktuddannelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="GarantiKursus"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 27)]
    public enumJN GarantiKursus
    {
        get => garantiKursusField;
        set => garantiKursusField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="DeltagerPrisBeloeb"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 28)]
    public decimal DeltagerPrisBeloeb
    {
        get => deltagerPrisBeloebField;
        set => deltagerPrisBeloebField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="DeltagerPrisBeloebSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool DeltagerPrisBeloebSpecified
    {
        get => deltagerPrisBeloebFieldSpecified;
        set => deltagerPrisBeloebFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Skole"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
    public skoleType Skole
    {
        get => skoleField;
        set => skoleField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Lokation"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
    public lokationType Lokation
    {
        get => lokationField;
        set => lokationField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Uddannelse"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 31)]
    public uddannelseType Uddannelse
    {
        get => uddannelseField;
        set => uddannelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="HoldPladsListe"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("HoldPladsListe", Order = 32)]
    public holdPladsType[] HoldPladsListe
    {
        get => holdPladsListeField;
        set => holdPladsListeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TillegsprisListe"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("TillegsprisListe", Order = 33)]
    public tillegsprisType[] TillegsprisListe
    {
        get => tillegsprisListeField;
        set => tillegsprisListeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="SkolefagPaHoldListe"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("SkolefagPaHoldListe", Order = 34)]
    public skolefagPaHoldType[] SkolefagPaHoldListe
    {
        get => skolefagPaHoldListeField;
        set => skolefagPaHoldListeField = value;
    }
}