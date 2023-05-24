using System;

namespace STIL.ServiceClient.DTOs.VEU.HentUdbud;

/// <summary>
/// The hent udbud response class.
/// </summary>
/// <seealso cref="ResponseType"/>
[Serializable]
[System.Diagnostics.DebuggerStepThroughAttribute]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
public class HentUdbudResponse1 : ResponseType
{
    /// <summary>
    /// The behandlingstidspunkt field.
    /// </summary>
    private DateTime behandlingstidspunktField;

    /// <summary>
    /// The opdatering liste field.
    /// </summary>
    private Opdatering[] opdateringListeField;

    /// <summary>
    /// Gets or sets the <see cref="Behandlingstidspunkt"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public DateTime Behandlingstidspunkt
    {
        get => behandlingstidspunktField;
        set => behandlingstidspunktField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="OpdateringListe"/> value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("OpdateringListe", Order = 1)]
    public Opdatering[] OpdateringListe
    {
        get => opdateringListeField;
        set => opdateringListeField = value;
    }
}