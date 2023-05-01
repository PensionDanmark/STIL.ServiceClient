namespace STIL.Entities.VEU.HentUdbud;

[Serializable]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public enum UndervisningsformType
{
    Aftenundervisning,
    Fjernundervisning,
    Dagundervisning,
    Weekendundervisning,

    [System.Xml.Serialization.XmlEnumAttribute("På fremmedsprog")]
    Påfremmedsprog,
}