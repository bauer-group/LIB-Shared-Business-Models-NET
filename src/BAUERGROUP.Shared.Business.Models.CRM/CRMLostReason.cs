namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Why an opportunity or lead was lost. Drives win/loss analysis.</summary>
public enum CRMLostReason
{
    /// <summary>Reason not recorded.</summary>
    Unspecified = 0,
    Price = 1,
    Competitor = 2,
    NoBudget = 3,
    NoDecision = 4,
    Timing = 5,
    StatusQuo = 6,
    ProductFit = 7,
    NoResponse = 8,
    /// <summary>A reason that does not fit the predefined set.</summary>
    Other = 9999
}
