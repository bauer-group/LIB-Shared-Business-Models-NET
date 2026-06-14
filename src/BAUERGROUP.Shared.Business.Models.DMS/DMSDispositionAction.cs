namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>What happens to a document once its retention period elapses.</summary>
public enum DMSDispositionAction
{
    /// <summary>No disposition defined.</summary>
    None = 0,
    /// <summary>Flag for human review before any action.</summary>
    Review = 1,
    /// <summary>Destroy / delete the record.</summary>
    Destroy = 2,
    /// <summary>Transfer to an archive or another system.</summary>
    Transfer = 3,
    /// <summary>Retain permanently (never dispose).</summary>
    RetainPermanent = 4
}
