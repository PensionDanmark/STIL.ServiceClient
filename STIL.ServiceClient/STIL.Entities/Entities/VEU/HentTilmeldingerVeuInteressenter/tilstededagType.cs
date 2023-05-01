namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThrough()]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilstededag")]
public partial class tilstededagType
{

    private System.DateTime datoField;

    private decimal normTimerField;

    private bool normTimerFieldSpecified;

    private decimal timerTilstedeField;

    private bool timerTilstedeFieldSpecified;

    private undervisningsstedType undervisningsstedField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(DataType = "date", Order = 0)]
    public System.DateTime Dato
    {
        get
        {
            return datoField;
        }
        set
        {
            datoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public decimal NormTimer
    {
        get
        {
            return normTimerField;
        }
        set
        {
            normTimerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool NormTimerSpecified
    {
        get
        {
            return normTimerFieldSpecified;
        }
        set
        {
            normTimerFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public decimal TimerTilstede
    {
        get
        {
            return timerTilstedeField;
        }
        set
        {
            timerTilstedeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool TimerTilstedeSpecified
    {
        get
        {
            return timerTilstedeFieldSpecified;
        }
        set
        {
            timerTilstedeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 3)]
    public undervisningsstedType Undervisningssted
    {
        get
        {
            return undervisningsstedField;
        }
        set
        {
            undervisningsstedField = value;
        }
    }
}