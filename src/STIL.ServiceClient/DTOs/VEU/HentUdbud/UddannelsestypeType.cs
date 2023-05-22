using System;

namespace STIL.Entities.VEU.HentUdbud;

[Serializable]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public enum UddannelsestypeType
{
    AUUD,
    FKB,
    AMU,
    FUUD,
    ÅU,
    ORD,
    FU,
    AFVU,
    HFE,
}