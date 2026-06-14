using System;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// One entry in a document's audit trail — a who/what/when record of an action. Audit entries are
/// meant to be written once and never modified, providing the tamper-evident access history GoBD
/// and ISO 27001 expect.
/// </summary>
public class DMSAuditEntry : DMSObjectBase
{
    /// <summary>Initialises a new audit entry, stamping <see cref="Timestamp"/> with the current UTC time.</summary>
    public DMSAuditEntry()
    {
        DocumentUID = Guid.Empty;
        VersionUID = Guid.Empty;
        Action = DMSAuditAction.Unspecified;
        PrincipalUID = Guid.Empty;
        PrincipalName = @"";
        Timestamp = DateTime.UtcNow;
        Detail = @"";
        IpAddress = @"";
    }

    /// <summary>The document the action targeted.</summary>
    public Guid DocumentUID { get; set; }

    /// <summary>The specific version, when relevant.</summary>
    public Guid VersionUID { get; set; }

    /// <summary>The recorded action.</summary>
    public DMSAuditAction Action { get; set; }

    /// <summary>The acting principal (user / service), referenced by id.</summary>
    public Guid PrincipalUID { get; set; }

    /// <summary>Principal display name snapshot.</summary>
    public String PrincipalName { get; set; }

    /// <summary>When the action occurred (UTC).</summary>
    public DateTime Timestamp { get; set; }

    /// <summary>Additional context (e.g. old → new value, export target).</summary>
    public String Detail { get; set; }

    /// <summary>Originating IP address, if captured.</summary>
    public String IpAddress { get; set; }
}
