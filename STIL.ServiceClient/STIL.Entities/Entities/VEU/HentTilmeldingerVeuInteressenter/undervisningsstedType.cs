namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilstededag")]
    public partial class undervisningsstedType
    {

        private string navnField;

        private string gadeField;

        private string stedField;

        private string postnummerField;

        private string postdistriktField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
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
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string Gade
        {
            get
            {
                return gadeField;
            }
            set
            {
                gadeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string Sted
        {
            get
            {
                return stedField;
            }
            set
            {
                stedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string Postnummer
        {
            get
            {
                return postnummerField;
            }
            set
            {
                postnummerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string Postdistrikt
        {
            get
            {
                return postdistriktField;
            }
            set
            {
                postdistriktField = value;
            }
        }
    }
}