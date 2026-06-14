namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>Decision recorded by an approver on a workflow step.</summary>
public enum DMSApprovalDecision
{
    /// <summary>Awaiting a decision.</summary>
    Pending = 0,
    Approved = 1,
    Rejected = 2,
    /// <summary>Reassigned to another approver.</summary>
    Delegated = 3,
    /// <summary>Skipped (e.g. not applicable in this run).</summary>
    Skipped = 4,
    Abstained = 5
}
