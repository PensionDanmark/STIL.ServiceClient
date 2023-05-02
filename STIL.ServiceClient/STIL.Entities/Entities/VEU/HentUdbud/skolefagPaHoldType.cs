using System;

namespace STIL.Entities.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class skolefagPaHoldType
{
    private decimal varighedDageField;

    private decimal timerPrDagField;

    private bool timerPrDagFieldSpecified;

    private decimal justeretPrisField;

    private decimal fuldprisField;

    private bool fuldprisFieldSpecified;

    private decimal tillegsprisField;

    private bool tillegsprisFieldSpecified;

    private string tillegsprisArsagField;

    private enumJN primertFagField;

    private bool primertFagFieldSpecified;

    private enumJN arvesField;

    private bool arvesFieldSpecified;

    private enumJN foregarUndervisningPaVirkField;

    private bool foregarUndervisningPaVirkFieldSpecified;

    private enumJN fjernundervisningField;

    private bool fjernundervisningFieldSpecified;

    private skolefagType skolefagField;

    private UVMfagType uVMfagField;

    private skoleType godkendtSkoleField;

    private skoleType gennemforendeSkoleField;

    private skolefagUddannelseType uddannelseField;

    private skoleFagPaHoldUdliciteretTil udliciteretTilField;

    private fagPeriodeType[] fagPeriodeListeField;

    private fagPladsType[] fagPladsListeField;

    private tillegsprisType[] tillegsprisListeField;

    /// <summary>
    /// Gets or sets the <see cref="VarighedDage"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public decimal VarighedDage
    {
        get => varighedDageField;
        set => varighedDageField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TimerPrDag"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public decimal TimerPrDag
    {
        get => timerPrDagField;
        set => timerPrDagField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TimerPrDagSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool TimerPrDagSpecified
    {
        get => timerPrDagFieldSpecified;
        set => timerPrDagFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="JusteretPris"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public decimal JusteretPris
    {
        get => justeretPrisField;
        set => justeretPrisField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Fuldpris"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public decimal Fuldpris
    {
        get => fuldprisField;
        set => fuldprisField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="FuldprisSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool FuldprisSpecified
    {
        get => fuldprisFieldSpecified;
        set => fuldprisFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Tillegspris"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public string TillegsprisArsag
    {
        get => tillegsprisArsagField;
        set => tillegsprisArsagField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="PrimertFag"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
    public enumJN PrimertFag
    {
        get => primertFagField;
        set => primertFagField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="PrimertFagSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool PrimertFagSpecified
    {
        get => primertFagFieldSpecified;
        set => primertFagFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Arves"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
    public enumJN Arves
    {
        get => arvesField;
        set => arvesField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ArvesSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool ArvesSpecified
    {
        get => arvesFieldSpecified;
        set => arvesFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ForegarUndervisningPaVirk"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
    public enumJN ForegarUndervisningPaVirk
    {
        get => foregarUndervisningPaVirkField;
        set => foregarUndervisningPaVirkField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="ForegarUndervisningPaVirkSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool ForegarUndervisningPaVirkSpecified
    {
        get => foregarUndervisningPaVirkFieldSpecified;
        set => foregarUndervisningPaVirkFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Fjernundervisning"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
    public enumJN Fjernundervisning
    {
        get => fjernundervisningField;
        set => fjernundervisningField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="FjernundervisningSpecified"/> value
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool FjernundervisningSpecified
    {
        get => fjernundervisningFieldSpecified;
        set => fjernundervisningFieldSpecified = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Skolefag"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
    public skolefagType Skolefag
    {
        get => skolefagField;
        set => skolefagField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="UVMfag"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
    public UVMfagType UVMfag
    {
        get => uVMfagField;
        set => uVMfagField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="GodkendtSkole"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
    public skoleType GodkendtSkole
    {
        get => godkendtSkoleField;
        set => godkendtSkoleField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="GennemforendeSkole"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
    public skoleType GennemforendeSkole
    {
        get => gennemforendeSkoleField;
        set => gennemforendeSkoleField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="Uddannelse"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
    public skolefagUddannelseType Uddannelse
    {
        get => uddannelseField;
        set => uddannelseField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="UdliciteretTil"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
    public skoleFagPaHoldUdliciteretTil UdliciteretTil
    {
        get => udliciteretTilField;
        set => udliciteretTilField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="FagPeriodeListe"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("FagPeriodeListe", Order = 16)]
    public fagPeriodeType[] FagPeriodeListe
    {
        get => fagPeriodeListeField;
        set => fagPeriodeListeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="FagPladsListe"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("FagPladsListe", Order = 17)]
    public fagPladsType[] FagPladsListe
    {
        get => fagPladsListeField;
        set => fagPladsListeField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="TillegsprisListe"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("TillegsprisListe", Order = 18)]
    public tillegsprisType[] TillegsprisListe
    {
        get => tillegsprisListeField;
        set => tillegsprisListeField = value;
    }
}