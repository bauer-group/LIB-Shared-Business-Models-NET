namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// CRM classification of an account. Distinct from the inherited ERP
/// <c>BusinessType</c> (Customer/Supplier/Internal) — this captures the relationship
/// stage from the CRM's point of view.
/// </summary>
public enum CRMAccountType
{
    /// <summary>Not classified.</summary>
    Unspecified = 0,
    Prospect = 1,
    Customer = 2,
    Partner = 3,
    Reseller = 4,
    Vendor = 5,
    Competitor = 6,
    /// <summary>A relationship that does not fit the predefined types.</summary>
    Other = 9999
}
