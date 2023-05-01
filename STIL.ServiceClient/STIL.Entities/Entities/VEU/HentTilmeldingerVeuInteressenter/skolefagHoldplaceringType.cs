namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThrough()]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/skolefagHoldplace" +
                                                     "ring")]
public partial class skolefagHoldplaceringType
{

    private skolefagType skolefagField;

    private System.DateTime startdatoField;

    private System.DateTime slutdatoField;

    private bool slutdatoFieldSpecified;

    private string gennemfortField;

    private enumJN fjernundervisningField;

    private bool fjernundervisningFieldSpecified;

    private enumJN foregarUndervisningPaaVirkField;

    private bool foregarUndervisningPaaVirkFieldSpecified;

    private enumJN certifikatkursusField;

    private bool certifikatkursusFieldSpecified;

    private decimal varighedDageField;

    private bool varighedDageFieldSpecified;

    private decimal normeretVarighedField;

    private bool normeretVarighedFieldSpecified;

    private tilstededagType[] tilstededagListeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public skolefagType Skolefag
    {
        get
        {
            return skolefagField;
        }
        set
        {
            skolefagField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 1)]
    public System.DateTime Startdato
    {
        get
        {
            return startdatoField;
        }
        set
        {
            startdatoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 2)]
    public System.DateTime Slutdato
    {
        get
        {
            return slutdatoField;
        }
        set
        {
            slutdatoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool SlutdatoSpecified
    {
        get
        {
            return slutdatoFieldSpecified;
        }
        set
        {
            slutdatoFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public string Gennemfort
    {
        get
        {
            return gennemfortField;
        }
        set
        {
            gennemfortField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 4)]
    public enumJN Fjernundervisning
    {
        get
        {
            return fjernundervisningField;
        }
        set
        {
            fjernundervisningField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool FjernundervisningSpecified
    {
        get
        {
            return fjernundervisningFieldSpecified;
        }
        set
        {
            fjernundervisningFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 5)]
    public enumJN ForegarUndervisningPaaVirk
    {
        get
        {
            return foregarUndervisningPaaVirkField;
        }
        set
        {
            foregarUndervisningPaaVirkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool ForegarUndervisningPaaVirkSpecified
    {
        get
        {
            return foregarUndervisningPaaVirkFieldSpecified;
        }
        set
        {
            foregarUndervisningPaaVirkFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 6)]
    public enumJN Certifikatkursus
    {
        get
        {
            return certifikatkursusField;
        }
        set
        {
            certifikatkursusField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool CertifikatkursusSpecified
    {
        get
        {
            return certifikatkursusFieldSpecified;
        }
        set
        {
            certifikatkursusFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 7)]
    public decimal VarighedDage
    {
        get
        {
            return varighedDageField;
        }
        set
        {
            varighedDageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool VarighedDageSpecified
    {
        get
        {
            return varighedDageFieldSpecified;
        }
        set
        {
            varighedDageFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 8)]
    public decimal NormeretVarighed
    {
        get
        {
            return normeretVarighedField;
        }
        set
        {
            normeretVarighedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool NormeretVarighedSpecified
    {
        get
        {
            return normeretVarighedFieldSpecified;
        }
        set
        {
            normeretVarighedFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArray(Order = 9)]
    [System.Xml.Serialization.XmlArrayItem("Tilstededag", Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilstededag", IsNullable = false)]
    public tilstededagType[] TilstededagListe
    {
        get
        {
            return tilstededagListeField;
        }
        set
        {
            tilstededagListeField = value;
        }
    }
}