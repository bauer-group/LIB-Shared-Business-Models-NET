namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// Origin channel through which a lead, account, opportunity or campaign member
/// entered the CRM. Shared across the CRM modules.
/// </summary>
public enum CRMSource
{
    /// <summary>Source not recorded.</summary>
    Unspecified = 0,
    Web = 1,
    Referral = 2,
    Advertisement = 3,
    Email = 4,
    Phone = 5,
    Event = 6,
    TradeFair = 7,
    SocialMedia = 8,
    Partner = 9,
    ColdCall = 10,
    Campaign = 11,
    Import = 12,
    /// <summary>A source that does not fit the predefined channels.</summary>
    Other = 9999
}
