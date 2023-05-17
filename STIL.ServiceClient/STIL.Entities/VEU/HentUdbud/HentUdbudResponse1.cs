using System;

namespace STIL.Entities.VEU.HentUdbud;

[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class HentUdbudResponse1 : ResponseType
{
    private DateTime behandlingstidspunktField;

    private Opdatering[] opdateringListeField;

    /// <summary>
    /// Gets or sets the <see cref="Behandlingstidspunkt"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public DateTime Behandlingstidspunkt
    {
        get => behandlingstidspunktField;
        set => behandlingstidspunktField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="OpdateringListe"/> value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("OpdateringListe", Order = 1)]
    public Opdatering[] OpdateringListe
    {
        get => opdateringListeField;
        set => opdateringListeField = value;
    }
}