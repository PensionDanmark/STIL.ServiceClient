using System;
using System.Collections.Generic;
using System.Text;

namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlRoot(ElementName = "HentOptagedePladserResponse", Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class HentOptagedePladserResponse1
    {

        public STIL.Entities.VEU.HentOptagedePladser.Identifier Identifier;

        public string CorrelationID;

        public STIL.Entities.VEU.HentOptagedePladser.HentOptagedePladserResponseMessage Message;

        public HentOptagedePladserResponse1()
        {
        }

        public HentOptagedePladserResponse1(STIL.Entities.VEU.HentOptagedePladser.Identifier Identifier, string CorrelationID, STIL.Entities.VEU.HentOptagedePladser.HentOptagedePladserResponseMessage Message)
        {
            this.Identifier = Identifier;
            this.CorrelationID = CorrelationID;
            this.Message = Message;
        }
    }
}
