namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>Channel a service case was raised through.</summary>
public enum CRMCaseChannel
{
    /// <summary>Channel not recorded.</summary>
    Unspecified = 0,
    Phone = 1,
    Email = 2,
    Web = 3,
    Portal = 4,
    Chat = 5,
    SocialMedia = 6,
    InPerson = 7,
    /// <summary>A channel that does not fit the predefined set.</summary>
    Other = 9999
}
