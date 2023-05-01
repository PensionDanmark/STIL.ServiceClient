namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
    public partial class personType
    {

        private string cPRnummerField;

        private string statusCPRnummerField;

        private tilmeldingType[] tilmeldingsListeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string CPRnummer
        {
            get
            {
                return cPRnummerField;
            }
            set
            {
                cPRnummerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string StatusCPRnummer
        {
            get
            {
                return statusCPRnummerField;
            }
            set
            {
                statusCPRnummerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 2)]
        [System.Xml.Serialization.XmlArrayItem("Tilmelding", Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding", IsNullable = false)]
        public tilmeldingType[] TilmeldingsListe
        {
            get
            {
                return tilmeldingsListeField;
            }
            set
            {
                tilmeldingsListeField = value;
            }
        }
    }
}