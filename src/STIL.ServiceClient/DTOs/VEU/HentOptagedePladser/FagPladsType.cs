namespace STIL.Entities.VEU.HentOptagedePladser
{
    /// <summary>
    /// FagPladsType.
    /// </summary>
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class FagPladsType
    {
        private System.DateTime datoField;
        private decimal optagetAntalPladserField;

        /// <summary>
        /// Gets or sets the <see cref="Dato"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 0)]
        public System.DateTime Dato
        {
            get => datoField;
            set => datoField = value;
        }

        /// <summary>
        /// Gets or sets the <see cref="OptagetAntalPladser"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public decimal OptagetAntalPladser
        {
            get => optagetAntalPladserField;
            set => optagetAntalPladserField = value;
        }
    }
}