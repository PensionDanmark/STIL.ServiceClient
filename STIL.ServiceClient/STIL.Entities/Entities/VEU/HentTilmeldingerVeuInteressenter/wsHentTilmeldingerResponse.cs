namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
    public partial class wsHentTilmeldingerResponse
    {

        private hentTilmeldingerResResultat resultatField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public hentTilmeldingerResResultat Resultat
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