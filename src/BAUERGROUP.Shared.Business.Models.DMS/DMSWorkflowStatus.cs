namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>Overall state of a document workflow instance.</summary>
public enum DMSWorkflowStatus
{
    /// <summary>Created but not yet started.</summary>
    NotStarted = 0,
    InProgress = 1,
    Approved = 2,
    Rejected = 3,
    Canceled = 4,
    Escalated = 5,
    OnHold = 6
}
