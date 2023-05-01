namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
    public partial class tilmeldingType
    {

        private string hoplGUIDField;

        private personoplysningerTilmeldingType personoplysningerTilmeldingField;

        private arbejdsgiverType arbejdsgiverField;

        private skoleType skoleField;

        private holdType holdField;

        private holdplaceringType holdplaceringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string HoplGUID
        {
            get
            {
                return hoplGUIDField;
            }
            set
            {
                hoplGUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public personoplysningerTilmeldingType PersonoplysningerTilmelding
        {
            get
            {
                return personoplysningerTilmeldingField;
            }
            set
            {
                personoplysningerTilmeldingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public arbejdsgiverType Arbejdsgiver
        {
            get
            {
                return arbejdsgiverField;
            }
            set
            {
                arbejdsgiverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public skoleType Skole
        {
            get
            {
                return skoleField;
            }
            set
            {
                skoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 4)]
        public holdType Hold
        {
            get
            {
                return holdField;
            }
            set
            {
                holdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 5)]
        public holdplaceringType Holdplacering
        {
            get
            {
                return holdplaceringField;
            }
            set
            {
                holdplaceringField = value;
            }
        }
    }
}