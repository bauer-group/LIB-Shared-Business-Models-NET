namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Resolution state of an opportunity.</summary>
public enum CRMOpportunityStatus
{
    /// <summary>Still in the pipeline.</summary>
    Open = 0,
    Won = 1,
    Lost = 2,
    Abandoned = 3
}
