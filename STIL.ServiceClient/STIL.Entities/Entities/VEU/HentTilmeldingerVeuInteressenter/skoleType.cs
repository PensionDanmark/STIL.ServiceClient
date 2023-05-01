namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
    public partial class skoleType
    {

        private string dSnrField;

        private string navnField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string DSnr
        {
            get
            {
                return dSnrField;
            }
            set
            {
                dSnrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
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
    }
}