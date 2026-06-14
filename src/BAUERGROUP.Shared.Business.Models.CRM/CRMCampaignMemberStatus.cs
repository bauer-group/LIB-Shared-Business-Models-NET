namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Response state of a contact or lead within a campaign.</summary>
public enum CRMCampaignMemberStatus
{
    /// <summary>State not set.</summary>
    Unspecified = 0,
    Targeted = 1,
    Sent = 2,
    Opened = 3,
    Clicked = 4,
    Responded = 5,
    Bounced = 6,
    Unsubscribed = 7,
    Converted = 8
}
