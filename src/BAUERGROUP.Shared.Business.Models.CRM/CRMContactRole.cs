namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Role a contact plays within an account's buying / relationship structure.</summary>
public enum CRMContactRole
{
    /// <summary>Role not set.</summary>
    Unspecified = 0,
    DecisionMaker = 1,
    Influencer = 2,
    Buyer = 3,
    TechnicalContact = 4,
    BillingContact = 5,
    Gatekeeper = 6,
    EndUser = 7,
    Executive = 8,
    /// <summary>A role that does not fit the predefined set.</summary>
    Other = 9999
}
