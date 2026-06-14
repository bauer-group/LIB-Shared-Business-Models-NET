namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Lifecycle state of a service case / ticket.</summary>
public enum CRMCaseStatus
{
    /// <summary>Just created, not yet picked up.</summary>
    New = 0,
    Assigned = 1,
    InProgress = 2,
    OnHold = 3,
    WaitingForCustomer = 4,
    Resolved = 5,
    Closed = 6,
    Reopened = 7,
    Canceled = 8
}
