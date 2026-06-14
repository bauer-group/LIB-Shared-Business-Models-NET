namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// GDPR / marketing consent state of a contact or lead. Tracks whether the person
/// has agreed to be contacted.
/// </summary>
public enum CRMConsentStatus
{
    /// <summary>Consent state unknown / never captured.</summary>
    Unknown = 0,
    OptedIn = 1,
    OptedOut = 2,
    Pending = 3,
    Withdrawn = 4
}
