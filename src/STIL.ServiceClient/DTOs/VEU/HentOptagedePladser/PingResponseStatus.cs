namespace STIL.Entities.VEU.HentOptagedePladser
{
    /// <summary>
    /// PingResponseStatus.
    /// </summary>
    [System.SerializableAttribute]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public enum PingResponseStatus
    {
        up,
        down,
    }
}