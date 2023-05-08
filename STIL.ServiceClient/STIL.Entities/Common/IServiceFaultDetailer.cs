namespace STIL.Entities.Common;

public interface IServiceFaultDetailer
{
    /// <summary>
    /// Gets or sets the <see cref="CorrelationID"/> value.
    /// </summary>
    string CorrelationID { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Timestamp"/> value.
    /// </summary>
    System.DateTime Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="ErrorCode"/> value.
    /// </summary>
    string ErrorCode { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="ErrorMessage"/> value.
    /// </summary>
    string ErrorMessage { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Details"/> value.
    /// </summary>
    string Details { get; set; }
}