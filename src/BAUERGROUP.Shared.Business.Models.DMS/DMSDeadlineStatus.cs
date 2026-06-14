namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>Handling state of a deadline / follow-up.</summary>
public enum DMSDeadlineStatus
{
    /// <summary>Open and pending.</summary>
    Open = 0,
    InProgress = 1,
    Done = 2,
    Overdue = 3,
    Canceled = 4
}
