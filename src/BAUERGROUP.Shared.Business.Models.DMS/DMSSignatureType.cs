namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// Assurance level of an electronic signature, following the eIDAS tiers, plus the electronic-seal
/// variant used by organizations.
/// </summary>
public enum DMSSignatureType
{
    /// <summary>Not specified.</summary>
    Unspecified = 0,
    /// <summary>Simple electronic signature (SES).</summary>
    Simple = 1,
    /// <summary>Advanced electronic signature (AES).</summary>
    Advanced = 2,
    /// <summary>Qualified electronic signature (QES).</summary>
    Qualified = 3,
    /// <summary>Electronic seal (organizational, not personal).</summary>
    Seal = 4
}
