namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
    public partial class holdplaceringType
    {

        private System.DateTime startdatoField;

        private System.DateTime slutdatoField;

        private string tilmeldingstypeField;

        private decimal deltagerprisField;

        private bool deltagerprisFieldSpecified;

        private skolefagHoldplaceringType[] skolefagHoldplaceringListeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(DataType = "date", Order = 0)]
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
        [System.Xml.Serialization.XmlElement(DataType = "date", Order = 1)]
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
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string Tilmeldingstype
        {
            get
            {
                return tilmeldingstypeField;
            }
            set
            {
                tilmeldingstypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public decimal Deltagerpris
        {
            get
            {
                return deltagerprisField;
            }
            set
            {
                deltagerprisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool DeltagerprisSpecified
        {
            get
            {
                return deltagerprisFieldSpecified;
            }
            set
            {
                deltagerprisFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 4)]
        [System.Xml.Serialization.XmlArrayItem("SkolefagHoldplacering", Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/skolefagHoldplace" +
            "ring", IsNullable = false)]
        public skolefagHoldplaceringType[] SkolefagHoldplaceringListe
        {
            get
            {
                return skolefagHoldplaceringListeField;
            }
            set
            {
                skolefagHoldplaceringListeField = value;
            }
        }
    }
}