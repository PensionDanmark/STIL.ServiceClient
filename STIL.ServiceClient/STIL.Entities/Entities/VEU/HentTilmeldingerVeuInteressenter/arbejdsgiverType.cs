namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
    public partial class arbejdsgiverType
    {

        private string cVRnrField;

        private string pnummerField;

        private string navnField;

        private string emailField;

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
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string Pnummer
        {
            get
            {
                return pnummerField;
            }
            set
            {
                pnummerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string Navn
        {
            get
            {
                return navnField;
            }
            set
            {
                navnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string Email
        {
            get
            {
                return emailField;
            }
            set
            {
                emailField = value;
            }
        }
    }
}