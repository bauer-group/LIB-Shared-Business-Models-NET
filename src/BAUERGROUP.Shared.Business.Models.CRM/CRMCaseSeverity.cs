namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// Technical impact severity of a case — distinct from <c>Priority</c> (the shared ERP urgency
/// scale), so impact and urgency can be tracked independently.
/// </summary>
public enum CRMCaseSeverity
{
    /// <summary>Severity not set.</summary>
    Unspecified = 0,
    Low = 1,
    Medium = 2,
    High = 3,
    Critical = 4
}
