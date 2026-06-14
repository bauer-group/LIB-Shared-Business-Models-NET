using System;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// An electronic signature or seal applied to a specific document version. Records the signer, the
/// eIDAS assurance level, the verification status, the signed-content hash and the signing
/// certificate metadata needed to validate the signature later.
/// </summary>
public class DMSSignature : DMSObjectBase
{
    /// <summary>Initialises a new, as-yet-unsigned signature with SHA-256 defaults.</summary>
    public DMSSignature()
    {
        SignedVersionUID = Guid.Empty;
        SignerUID = Guid.Empty;
        SignerName = @"";
        SignatureType = DMSSignatureType.Simple;
        Status = DMSSignatureStatus.Unsigned;
        SignedAt = null;
        ContentHash = @"";
        HashAlgorithm = DMSHashAlgorithm.SHA256;
        CertificateIssuer = @"";
        CertificateSerial = @"";
        CertificateValidFrom = null;
        CertificateValidTo = null;
        Reason = @"";
        Location = @"";
    }

    /// <summary>The document version that was signed.</summary>
    public Guid SignedVersionUID { get; set; }

    /// <summary>The signing principal, referenced by id.</summary>
    public Guid SignerUID { get; set; }

    /// <summary>Signer display name (e.g. from the certificate subject).</summary>
    public String SignerName { get; set; }

    /// <summary>eIDAS assurance level / seal.</summary>
    public DMSSignatureType SignatureType { get; set; }

    /// <summary>Verification state.</summary>
    public DMSSignatureStatus Status { get; set; }

    /// <summary>When the signature was applied.</summary>
    public DateTime? SignedAt { get; set; }

    /// <summary>Hash of the signed content (hex).</summary>
    public String ContentHash { get; set; }

    /// <summary>Algorithm used to compute <see cref="ContentHash"/>.</summary>
    public DMSHashAlgorithm HashAlgorithm { get; set; }

    /// <summary>Issuer (CA) of the signing certificate.</summary>
    public String CertificateIssuer { get; set; }

    /// <summary>Serial number of the signing certificate.</summary>
    public String CertificateSerial { get; set; }

    /// <summary>Certificate validity start.</summary>
    public DateTime? CertificateValidFrom { get; set; }

    /// <summary>Certificate validity end.</summary>
    public DateTime? CertificateValidTo { get; set; }

    /// <summary>Stated reason for signing.</summary>
    public String Reason { get; set; }

    /// <summary>Stated location of signing.</summary>
    public String Location { get; set; }
}
