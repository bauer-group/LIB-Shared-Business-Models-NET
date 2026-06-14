namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Qualitative engagement / interest rating shared by accounts and leads.</summary>
public enum CRMRating
{
    /// <summary>Not rated.</summary>
    Unspecified = 0,
    Cold = 1,
    Warm = 2,
    Hot = 3
}
