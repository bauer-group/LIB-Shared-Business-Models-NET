namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Completion state of an activity.</summary>
public enum CRMActivityStatus
{
    /// <summary>Not yet started.</summary>
    Open = 0,
    InProgress = 1,
    Completed = 2,
    Canceled = 3,
    Deferred = 4
}
