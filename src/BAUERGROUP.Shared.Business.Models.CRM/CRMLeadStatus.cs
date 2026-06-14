namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Qualification state of a lead as it moves toward conversion.</summary>
public enum CRMLeadStatus
{
    /// <summary>State not set.</summary>
    Unspecified = 0,
    New = 1,
    Working = 2,
    Nurturing = 3,
    Qualified = 4,
    Unqualified = 5,
    Converted = 6,
    Lost = 7
}
