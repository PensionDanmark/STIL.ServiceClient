﻿namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class PingResponse
    {
        private PingResponseStatus statusField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PingResponseStatus Status
        {
            get => statusField;
            set => statusField = value;
        }
    }
}