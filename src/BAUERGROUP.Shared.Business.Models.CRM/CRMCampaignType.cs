namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Marketing channel / format of a campaign.</summary>
public enum CRMCampaignType
{
    /// <summary>Type not set.</summary>
    Unspecified = 0,
    Email = 1,
    Event = 2,
    Webinar = 3,
    TradeFair = 4,
    Advertisement = 5,
    SocialMedia = 6,
    Telemarketing = 7,
    DirectMail = 8,
    ContentMarketing = 9,
    /// <summary>A format that does not fit the predefined types.</summary>
    Other = 9999
}
