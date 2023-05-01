namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
    public partial class hentTilmeldingerResResultat
    {

        private string instNrField;

        private string svarKodeField;

        private string svarTekstField;

        private personType[] personListeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string SvarKode
        {
            get
            {
                return svarKodeField;
            }
            set
            {
                svarKodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string SvarTekst
        {
            get
            {
                return svarTekstField;
            }
            set
            {
                svarTekstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 3)]
        [System.Xml.Serialization.XmlArrayItem("Person", IsNullable = false)]
        public personType[] PersonListe
        {
            get
            {
                return personListeField;
            }
            set
            {
                personListeField = value;
            }
        }
    }
}