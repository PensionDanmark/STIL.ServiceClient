using System;

namespace STIL.Entities.Entities.VEU.HentUdbud;

[Serializable]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentudbud/v1.0")]
public enum PingResponseStatus
{
    up,
    down,
}