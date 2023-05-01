namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(TypeName = "hentTilmeldingerResponse", Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
    public partial class hentTilmeldingerResponse1
    {

        private wsSyncResModtagerV2 wsSyncResModtagerV2Field;

        private wsHentTilmeldingerResponse resultatField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public wsSyncResModtagerV2 wsSyncResModtagerV2
        {
            get
            {
                return wsSyncResModtagerV2Field;
            }
            set
            {
                wsSyncResModtagerV2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public wsHentTilmeldingerResponse Resultat
        {
            get
            {
                return resultatField;
            }
            set
            {
                resultatField = value;
            }
        }
    }
}