using System;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// The retention state applied to a specific document: the assigned policy, the computed
/// retain-until date, any legal hold (which suspends disposition) and the disposition outcome.
/// Owned by <see cref="DMSDocument"/>.
/// </summary>
public class DMSRetention : DMSObjectBase
{
    /// <summary>Initialises a new retention state with neutral defaults.</summary>
    public DMSRetention()
    {
        PolicyUID = Guid.Empty;
        Category = DMSRetentionCategory.Unspecified;
        RetentionStart = null;
        RetainUntil = null;
        DispositionAction = DMSDispositionAction.Review;
        IsOnLegalHold = false;
        LegalHoldReason = @"";
        IsDisposed = false;
        DisposedAt = null;
    }

    /// <summary>Assigned retention policy (<see cref="DMSRetentionPolicy"/>).</summary>
    public Guid PolicyUID { get; set; }

    /// <summary>Records category snapshot.</summary>
    public DMSRetentionCategory Category { get; set; }

    /// <summary>When the retention period starts (e.g. end of the fiscal year of creation).</summary>
    public DateTime? RetentionStart { get; set; }

    /// <summary>Date until which the document must be retained.</summary>
    public DateTime? RetainUntil { get; set; }

    /// <summary>Disposition action once the period elapses.</summary>
    public DMSDispositionAction DispositionAction { get; set; }

    /// <summary>Whether a legal hold suspends disposition.</summary>
    public Boolean IsOnLegalHold { get; set; }

    /// <summary>Reason for the legal hold.</summary>
    public String LegalHoldReason { get; set; }

    /// <summary>Whether the document has been disposed of.</summary>
    public Boolean IsDisposed { get; set; }

    /// <summary>When disposition occurred.</summary>
    public DateTime? DisposedAt { get; set; }
}
