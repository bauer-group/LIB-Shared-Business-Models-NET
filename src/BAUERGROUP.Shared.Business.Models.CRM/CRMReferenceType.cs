namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// Discriminator for a polymorphic CRM reference (e.g. the subject an activity or
/// link points at). Pairs with a <c>Guid</c> referral id.
/// </summary>
public enum CRMReferenceType
{
    /// <summary>No target / not set.</summary>
    Unspecified = 0,
    Account = 1,
    Contact = 2,
    Lead = 3,
    Opportunity = 4,
    Case = 5,
    Campaign = 6,
    Activity = 7,
    /// <summary>A target outside the predefined CRM entity set.</summary>
    Other = 9999
}
