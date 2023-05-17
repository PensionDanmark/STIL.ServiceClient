using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlRoot(ElementName = "HentOptagedePladserRequest", Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class HentOptagedePladserRequest
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public STIL.Entities.VEU.HentOptagedePladser.Identifier Identifier;

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public STIL.Entities.VEU.HentOptagedePladser.HentOptagedePladserRequestMessage Message;

        public HentOptagedePladserRequest()
        {
        }

        public HentOptagedePladserRequest(STIL.Entities.VEU.HentOptagedePladser.Identifier Identifier, STIL.Entities.VEU.HentOptagedePladser.HentOptagedePladserRequestMessage Message)
        {
            this.Identifier = Identifier;
            this.Message = Message;
        }
    }
}
