namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// Confidentiality classification of a document, ascending in sensitivity so that access policies
/// can compare levels.
/// </summary>
public enum DMSSecurityClassification
{
    Public = 0,
    Internal = 1,
    Confidential = 2,
    Restricted = 3,
    Secret = 4
}
