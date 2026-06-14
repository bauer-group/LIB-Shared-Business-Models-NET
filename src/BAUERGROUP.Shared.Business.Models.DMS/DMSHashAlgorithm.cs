namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>Hash algorithm used to bind a signature to the signed content.</summary>
public enum DMSHashAlgorithm
{
    /// <summary>Not specified.</summary>
    None = 0,
    SHA256 = 1,
    SHA384 = 2,
    SHA512 = 3,
    /// <summary>Legacy SHA-1 (discouraged; kept for verifying historical signatures).</summary>
    SHA1 = 4
}
