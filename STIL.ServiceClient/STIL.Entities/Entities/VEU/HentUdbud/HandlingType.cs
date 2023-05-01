using System;

namespace STIL.Entities.VEU.HentUdbud;

[Serializable]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public enum HandlingType
{
    OPRET,
    OPDATER,
    SLET,
}