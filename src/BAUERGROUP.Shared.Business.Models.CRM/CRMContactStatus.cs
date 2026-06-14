namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Engagement state of an individual contact.</summary>
public enum CRMContactStatus
{
    /// <summary>State not set.</summary>
    Unspecified = 0,
    Active = 1,
    Inactive = 2,
    Bounced = 3,
    Unsubscribed = 4,
    DoNotContact = 5,
    Archived = 6
}
