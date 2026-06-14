namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>Legal basis a retention rule rests on.</summary>
public enum DMSRetentionLegalBasis
{
    /// <summary>Not specified.</summary>
    Unspecified = 0,
    /// <summary>GoBD — principles for proper keeping of books and records in electronic form.</summary>
    GoBD = 1,
    /// <summary>§ 257 HGB — commercial retention duties.</summary>
    HGB_257 = 2,
    /// <summary>§ 147 AO — tax-code retention duties.</summary>
    AO_147 = 3,
    /// <summary>GDPR / DSGVO — data-protection driven retention / erasure.</summary>
    DSGVO = 4,
    /// <summary>Product-liability retention.</summary>
    ProductLiability = 5,
    /// <summary>A custom / contractual basis.</summary>
    Custom = 9999
}
