namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
    public partial class hentTilmeldingerReqIndhold
    {

        private string cVRnrField;

        private string[] cPRnummerListeField;

        private System.DateTime fraDatoField;

        private bool fraDatoFieldSpecified;

        private System.DateTime tilDatoField;

        private bool tilDatoFieldSpecified;

        private string instNrField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string CVRnr
        {
            get
            {
                return cVRnrField;
            }
            set
            {
                cVRnrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("CPRnummer", IsNullable = false)]
        public string[] CPRnummerListe
        {
            get
            {
                return cPRnummerListeField;
            }
            set
            {
                cPRnummerListeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(DataType = "date", Order = 2)]
        public System.DateTime FraDato
        {
            get
            {
                return fraDatoField;
            }
            set
            {
                fraDatoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool FraDatoSpecified
        {
            get
            {
                return fraDatoFieldSpecified;
            }
            set
            {
                fraDatoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(DataType = "date", Order = 3)]
        public System.DateTime TilDato
        {
            get
            {
                return tilDatoField;
            }
            set
            {
                tilDatoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool TilDatoSpecified
        {
            get
            {
                return tilDatoFieldSpecified;
            }
            set
            {
                tilDatoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string InstNr
        {
            get
            {
                return instNrField;
            }
            set
            {
                instNrField = value;
            }
        }
    }
}