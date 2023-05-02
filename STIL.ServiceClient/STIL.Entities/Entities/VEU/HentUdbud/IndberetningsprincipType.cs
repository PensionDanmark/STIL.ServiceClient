using System;

namespace STIL.Entities.Entities.VEU.HentUdbud;

[Serializable]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public enum IndberetningsprincipType
{
    P,
    S,
    SFI,
    AAV,
    ANDET,
}