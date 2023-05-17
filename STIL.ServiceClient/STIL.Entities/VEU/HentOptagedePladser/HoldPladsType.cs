namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class HoldPladsType
    {
        private System.DateTime datoField;
        private decimal optagetAntalPladserField;
        private bool optagetAntalPladserFieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 0)]
        public System.DateTime Dato
        {
            get => datoField;
            set => datoField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public decimal OptagetAntalPladser
        {
            get => optagetAntalPladserField;
            set => optagetAntalPladserField = value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool OptagetAntalPladserSpecified
        {
            get => optagetAntalPladserFieldSpecified;
            set => optagetAntalPladserFieldSpecified = value;
        }
    }
}