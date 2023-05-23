using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The hold class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class Hold
{
    /// <summary>
    /// The akti guid field.
    /// </summary>
    private string aktiGuidField;

    /// <summary>
    /// The startdato field.
    /// </summary>
    private DateTime startdatoField;

    /// <summary>
    /// The slutdato field.
    /// </summary>
    private DateTime slutdatoField;

    /// <summary>
    /// The kort betegnelse field.
    /// </summary>
    private string kortBetegnelseField;

    /// <summary>
    /// The betegnelse field.
    /// </summary>
    private string betegnelseField;

    /// <summary>
    /// The beskrivelse field.
    /// </summary>
    private string beskrivelseField;

    /// <summary>
    /// The navn field.
    /// </summary>
    private string uGNavnField;

    /// <summary>
    /// The antal pladser field.
    /// </summary>
    private decimal antalPladserField;

    /// <summary>
    /// The antal pladser field specified.
    /// </summary>
    private bool antalPladserFieldSpecified;

    /// <summary>
    /// The elev lektioner field.
    /// </summary>
    private decimal elevLektionerField;

    /// <summary>
    /// The elev lektioner field specified.
    /// </summary>
    private bool elevLektionerFieldSpecified;

    /// <summary>
    /// The aflyst field.
    /// </summary>
    private enumJN aflystField;

    /// <summary>
    /// The aflyst prdato field.
    /// </summary>
    private DateTime aflystPrdatoField;

    /// <summary>
    /// The aflyst prdato field specified.
    /// </summary>
    private bool aflystPrdatoFieldSpecified;

    /// <summary>
    /// The undervisningstid field.
    /// </summary>
    private string undervisningstidField;

    /// <summary>
    /// The undervisningsform field.
    /// </summary>
    private UndervisningsformType undervisningsformField;

    /// <summary>
    /// The undervisningsform field specified.
    /// </summary>
    private bool undervisningsformFieldSpecified;

    /// <summary>
    /// The tilmeldingsfrist field.
    /// </summary>
    private DateTime tilmeldingsfristField;

    /// <summary>
    /// The indberetningsprincip field.
    /// </summary>
    private IndberetningsprincipType indberetningsprincipField;

    /// <summary>
    /// The last field.
    /// </summary>
    private enumJN lastField;

    /// <summary>
    /// The forudsaetninger field.
    /// </summary>
    private string forudsaetningerField;

    /// <summary>
    /// The kviknr field.
    /// </summary>
    private string kviknrField;

    /// <summary>
    /// The kontaktperson field.
    /// </summary>
    private string kontaktpersonField;

    /// <summary>
    /// The kontakt telefonnr field.
    /// </summary>
    private string kontaktTelefonnrField;

    /// <summary>
    /// The email field.
    /// </summary>
    private string emailField;

    /// <summary>
    /// The hjemmeside field.
    /// </summary>
    private string hjemmesideField;

    /// <summary>
    /// The aktivitetsafdeling field.
    /// </summary>
    private string aktivitetsafdelingField;

    /// <summary>
    /// The projektomrade field.
    /// </summary>
    private string projektomradeField;

    /// <summary>
    /// The ansvarsomrade field.
    /// </summary>
    private string ansvarsomradeField;

    /// <summary>
    /// The minimum antal tilmeldte field.
    /// </summary>
    private decimal minimumAntalTilmeldteField;

    /// <summary>
    /// The minimum antal tilmeldte field specified.
    /// </summary>
    private bool minimumAntalTilmeldteFieldSpecified;

    /// <summary>
    /// The kontraktuddannelse field.
    /// </summary>
    private enumJN kontraktuddannelseField;

    /// <summary>
    /// The garanti kursus field.
    /// </summary>
    private enumJN garantiKursusField;

    /// <summary>
    /// The deltager pris beloeb field.
    /// </summary>
    private decimal deltagerPrisBeloebField;

    /// <summary>
    /// The deltager pris beloeb field specified.
    /// </summary>
    private bool deltagerPrisBeloebFieldSpecified;

    /// <summary>
    /// The skole field.
    /// </summary>
    private skoleType skoleField;

    /// <summary>
    /// The lokation field.
    /// </summary>
    private lokationType lokationField;

    /// <summary>
    /// The uddannelse field.
    /// </summary>
    private uddannelseType uddannelseField;

    /// <summary>
    /// The hold plads liste field.
    /// </summary>
    private holdPladsType[] holdPladsListeField;

    /// <summary>
    /// The tillegspris liste field.
    /// </summary>
    private tillegsprisType[] tillegsprisListeField;

    /// <summary>
    /// The skolefag pa hold liste field.
    /// </summary>
    private skolefagPaHoldType[] skolefagPaHoldListeField;

    /// <summary>
    /// Gets or sets the <see cref="AktiGuid"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public string AktiGuid
    {
        get => aktiGuidField;
        set => aktiGuidField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Startdato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 1)]
    public DateTime Startdato
    {
        get => startdatoField;
        set => startdatoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Slutdato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 2)]
    public DateTime Slutdato
    {
        get => slutdatoField;
        set => slutdatoField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="KortBetegnelse"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public string KortBetegnelse
    {
        get => kortBetegnelseField;
        set => kortBetegnelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Betegnelse"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public string Betegnelse
    {
        get => betegnelseField;
        set => betegnelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Beskrivelse"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public string Beskrivelse
    {
        get => beskrivelseField;
        set => beskrivelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="UGNavn"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
    public string UGNavn
    {
        get => uGNavnField;
        set => uGNavnField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="AntalPladser"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
    public decimal AntalPladser
    {
        get => antalPladserField;
        set => antalPladserField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether the <see cref="AntalPladserSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool AntalPladserSpecified
    {
        get => antalPladserFieldSpecified;
        set => antalPladserFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ElevLektioner"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
    public decimal ElevLektioner
    {
        get => elevLektionerField;
        set => elevLektionerField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="ElevLektionerSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool ElevLektionerSpecified
    {
        get => elevLektionerFieldSpecified;
        set => elevLektionerFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Aflyst"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
    public enumJN Aflyst
    {
        get => aflystField;
        set => aflystField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="AflystPrdato"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 10)]
    public DateTime AflystPrdato
    {
        get => aflystPrdatoField;
        set => aflystPrdatoField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="AflystPrdatoSpecified"/> value is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool AflystPrdatoSpecified
    {
        get => aflystPrdatoFieldSpecified;
        set => aflystPrdatoFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Undervisningstid"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
    public string Undervisningstid
    {
        get => undervisningstidField;
        set => undervisningstidField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Undervisningsform"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
    public UndervisningsformType Undervisningsform
    {
        get => undervisningsformField;
        set => undervisningsformField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="UndervisningsformSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool UndervisningsformSpecified
    {
        get => undervisningsformFieldSpecified;
        set => undervisningsformFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Tilmeldingsfrist"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 13)]
    public DateTime Tilmeldingsfrist
    {
        get => tilmeldingsfristField;
        set => tilmeldingsfristField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Indberetningsprincip"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
    public IndberetningsprincipType Indberetningsprincip
    {
        get => indberetningsprincipField;
        set => indberetningsprincipField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Last"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
    public enumJN Last
    {
        get => lastField;
        set => lastField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Forudsaetninger"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
    public string Forudsaetninger
    {
        get => forudsaetningerField;
        set => forudsaetningerField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Kviknr"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
    public string Kviknr
    {
        get => kviknrField;
        set => kviknrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Kontaktperson"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
    public string Kontaktperson
    {
        get => kontaktpersonField;
        set => kontaktpersonField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="KontaktTelefonnr"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
    public string KontaktTelefonnr
    {
        get => kontaktTelefonnrField;
        set => kontaktTelefonnrField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Email"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
    public string Email
    {
        get => emailField;
        set => emailField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Hjemmeside"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
    public string Hjemmeside
    {
        get => hjemmesideField;
        set => hjemmesideField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Aktivitetsafdeling"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
    public string Aktivitetsafdeling
    {
        get => aktivitetsafdelingField;
        set => aktivitetsafdelingField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Projektomrade"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
    public string Projektomrade
    {
        get => projektomradeField;
        set => projektomradeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Ansvarsomrade"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
    public string Ansvarsomrade
    {
        get => ansvarsomradeField;
        set => ansvarsomradeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="MinimumAntalTilmeldte"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 25)]
    public decimal MinimumAntalTilmeldte
    {
        get => minimumAntalTilmeldteField;
        set => minimumAntalTilmeldteField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="MinimumAntalTilmeldteSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool MinimumAntalTilmeldteSpecified
    {
        get => minimumAntalTilmeldteFieldSpecified;
        set => minimumAntalTilmeldteFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Kontraktuddannelse"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 26)]
    public enumJN Kontraktuddannelse
    {
        get => kontraktuddannelseField;
        set => kontraktuddannelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="GarantiKursus"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 27)]
    public enumJN GarantiKursus
    {
        get => garantiKursusField;
        set => garantiKursusField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="DeltagerPrisBeloeb"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 28)]
    public decimal DeltagerPrisBeloeb
    {
        get => deltagerPrisBeloebField;
        set => deltagerPrisBeloebField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="DeltagerPrisBeloebSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool DeltagerPrisBeloebSpecified
    {
        get => deltagerPrisBeloebFieldSpecified;
        set => deltagerPrisBeloebFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Skole"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
    public skoleType Skole
    {
        get => skoleField;
        set => skoleField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Lokation"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
    public lokationType Lokation
    {
        get => lokationField;
        set => lokationField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Uddannelse"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 31)]
    public uddannelseType Uddannelse
    {
        get => uddannelseField;
        set => uddannelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="HoldPladsListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("HoldPladsListe", Order = 32)]
    public holdPladsType[] HoldPladsListe
    {
        get => holdPladsListeField;
        set => holdPladsListeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TillegsprisListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("TillegsprisListe", Order = 33)]
    public tillegsprisType[] TillegsprisListe
    {
        get => tillegsprisListeField;
        set => tillegsprisListeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="SkolefagPaHoldListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("SkolefagPaHoldListe", Order = 34)]
    public skolefagPaHoldType[] SkolefagPaHoldListe
    {
        get => skolefagPaHoldListeField;
        set => skolefagPaHoldListeField = value;
    }
}