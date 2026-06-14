namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>Verification state of an electronic signature.</summary>
public enum DMSSignatureStatus
{
    /// <summary>No signature yet applied.</summary>
    Unsigned = 0,
    Pending = 1,
    Signed = 2,
    Verified = 3,
    Invalid = 4,
    Expired = 5,
    Revoked = 6
}
