using STIL.Entities.HentTilmeldingerVeuInteressenter;

namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
    public partial class hentTilmeldinger
    {

        private wsSyncReqModtagerV2 wsSyncReqModtagerV2Field;

        private hentTilmeldingerRequest beskedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public wsSyncReqModtagerV2 wsSyncReqModtagerV2
        {
            get
            {
                return wsSyncReqModtagerV2Field;
            }
            set
            {
                wsSyncReqModtagerV2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public hentTilmeldingerRequest Besked
        {
            get
            {
                return beskedField;
            }
            set
            {
                beskedField = value;
            }
        }
    }
}