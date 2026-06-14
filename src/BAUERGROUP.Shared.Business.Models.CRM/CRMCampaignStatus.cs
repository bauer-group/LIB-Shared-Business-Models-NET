namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Execution state of a campaign.</summary>
public enum CRMCampaignStatus
{
    /// <summary>Defined but not started.</summary>
    Planned = 0,
    InProgress = 1,
    Paused = 2,
    Completed = 3,
    Aborted = 4
}
