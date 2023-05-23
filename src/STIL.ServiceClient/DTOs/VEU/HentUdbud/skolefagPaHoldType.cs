using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The skolefag pa hold type class.
/// </summary>
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class skolefagPaHoldType
{
    /// <summary>
    /// The varighed dage field.
    /// </summary>
    private decimal varighedDageField;

    /// <summary>
    /// The timer pr dag field.
    /// </summary>
    private decimal timerPrDagField;

    /// <summary>
    /// The timer pr dag field specified.
    /// </summary>
    private bool timerPrDagFieldSpecified;

    /// <summary>
    /// The justeret pris field.
    /// </summary>
    private decimal justeretPrisField;

    /// <summary>
    /// The fuldpris field.
    /// </summary>
    private decimal fuldprisField;

    /// <summary>
    /// The fuldpris field specified.
    /// </summary>
    private bool fuldprisFieldSpecified;

    /// <summary>
    /// The tillegspris field.
    /// </summary>
    private decimal tillegsprisField;

    /// <summary>
    /// The tillegspris field specified.
    /// </summary>
    private bool tillegsprisFieldSpecified;

    /// <summary>
    /// The tillegspris arsag field.
    /// </summary>
    private string tillegsprisArsagField;

    /// <summary>
    /// The primert fag field.
    /// </summary>
    private enumJN primertFagField;

    /// <summary>
    /// The primert fag field specified.
    /// </summary>
    private bool primertFagFieldSpecified;

    /// <summary>
    /// The arves field.
    /// </summary>
    private enumJN arvesField;

    /// <summary>
    /// The arves field specified.
    /// </summary>
    private bool arvesFieldSpecified;

    /// <summary>
    /// The foregar undervisning pa virk field.
    /// </summary>
    private enumJN foregarUndervisningPaVirkField;

    /// <summary>
    /// The foregar undervisning pa virk field specified.
    /// </summary>
    private bool foregarUndervisningPaVirkFieldSpecified;

    /// <summary>
    /// The fjernundervisning field.
    /// </summary>
    private enumJN fjernundervisningField;

    /// <summary>
    /// The fjernundervisning field specified.
    /// </summary>
    private bool fjernundervisningFieldSpecified;

    /// <summary>
    /// The skolefag field.
    /// </summary>
    private skolefagType skolefagField;

    /// <summary>
    /// The mfag field.
    /// </summary>
    private UVMfagType uVMfagField;

    /// <summary>
    /// The godkendt skole field.
    /// </summary>
    private skoleType godkendtSkoleField;

    /// <summary>
    /// The gennemforende skole field.
    /// </summary>
    private skoleType gennemforendeSkoleField;

    /// <summary>
    /// The uddannelse field.
    /// </summary>
    private skolefagUddannelseType uddannelseField;

    /// <summary>
    /// The udliciteret til field.
    /// </summary>
    private skoleFagPaHoldUdliciteretTil udliciteretTilField;

    /// <summary>
    /// The fag periode liste field.
    /// </summary>
    private fagPeriodeType[] fagPeriodeListeField;

    /// <summary>
    /// The fag plads liste field.
    /// </summary>
    private fagPladsType[] fagPladsListeField;

    /// <summary>
    /// The tillegspris liste field.
    /// </summary>
    private tillegsprisType[] tillegsprisListeField;

    /// <summary>
    /// Gets or sets the <see cref="VarighedDage"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public decimal VarighedDage
    {
        get => varighedDageField;
        set => varighedDageField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TimerPrDag"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public decimal TimerPrDag
    {
        get => timerPrDagField;
        set => timerPrDagField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="TimerPrDagSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool TimerPrDagSpecified
    {
        get => timerPrDagFieldSpecified;
        set => timerPrDagFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="JusteretPris"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public decimal JusteretPris
    {
        get => justeretPrisField;
        set => justeretPrisField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Fuldpris"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public decimal Fuldpris
    {
        get => fuldprisField;
        set => fuldprisField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="FuldprisSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool FuldprisSpecified
    {
        get => fuldprisFieldSpecified;
        set => fuldprisFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Tillegspris"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public decimal Tillegspris
    {
        get => tillegsprisField;
        set => tillegsprisField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="TillegsprisSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool TillegsprisSpecified
    {
        get => tillegsprisFieldSpecified;
        set => tillegsprisFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TillegsprisArsag"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public string TillegsprisArsag
    {
        get => tillegsprisArsagField;
        set => tillegsprisArsagField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="PrimertFag"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
    public enumJN PrimertFag
    {
        get => primertFagField;
        set => primertFagField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="PrimertFagSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool PrimertFagSpecified
    {
        get => primertFagFieldSpecified;
        set => primertFagFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Arves"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
    public enumJN Arves
    {
        get => arvesField;
        set => arvesField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="ArvesSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool ArvesSpecified
    {
        get => arvesFieldSpecified;
        set => arvesFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ForegarUndervisningPaVirk"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
    public enumJN ForegarUndervisningPaVirk
    {
        get => foregarUndervisningPaVirkField;
        set => foregarUndervisningPaVirkField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="ForegarUndervisningPaVirkSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool ForegarUndervisningPaVirkSpecified
    {
        get => foregarUndervisningPaVirkFieldSpecified;
        set => foregarUndervisningPaVirkFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Fjernundervisning"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
    public enumJN Fjernundervisning
    {
        get => fjernundervisningField;
        set => fjernundervisningField = value;
    }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="FjernundervisningSpecified"/> is set.
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool FjernundervisningSpecified
    {
        get => fjernundervisningFieldSpecified;
        set => fjernundervisningFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Skolefag"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
    public skolefagType Skolefag
    {
        get => skolefagField;
        set => skolefagField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="UVMfag"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
    public UVMfagType UVMfag
    {
        get => uVMfagField;
        set => uVMfagField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="GodkendtSkole"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
    public skoleType GodkendtSkole
    {
        get => godkendtSkoleField;
        set => godkendtSkoleField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="GennemforendeSkole"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
    public skoleType GennemforendeSkole
    {
        get => gennemforendeSkoleField;
        set => gennemforendeSkoleField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Uddannelse"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
    public skolefagUddannelseType Uddannelse
    {
        get => uddannelseField;
        set => uddannelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="UdliciteretTil"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
    public skoleFagPaHoldUdliciteretTil UdliciteretTil
    {
        get => udliciteretTilField;
        set => udliciteretTilField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="FagPeriodeListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("FagPeriodeListe", Order = 16)]
    public fagPeriodeType[] FagPeriodeListe
    {
        get => fagPeriodeListeField;
        set => fagPeriodeListeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="FagPladsListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("FagPladsListe", Order = 17)]
    public fagPladsType[] FagPladsListe
    {
        get => fagPladsListeField;
        set => fagPladsListeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TillegsprisListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("TillegsprisListe", Order = 18)]
    public tillegsprisType[] TillegsprisListe
    {
        get => tillegsprisListeField;
        set => tillegsprisListeField = value;
    }
}