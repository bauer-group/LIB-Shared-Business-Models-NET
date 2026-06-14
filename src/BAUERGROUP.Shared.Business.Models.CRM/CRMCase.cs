using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.CRM.Bases;
using BAUERGROUP.Shared.Business.Models.ERP;

namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// A service / support case raised by a customer. Links its account, contact, owner and affected
/// product by id, and carries the timeline (opened → first response → resolved → closed) plus the
/// SLA target used by service-desk reporting. Urgency reuses the ERP <see cref="ERPPriority"/>
/// scale; technical impact is tracked separately via <see cref="Severity"/>.
/// </summary>
public class CRMCase : CRMObjectBase
{
    /// <summary>Initialises a new case, stamping <see cref="OpenedAt"/> with the current UTC time.</summary>
    public CRMCase()
    {
        Reference = Subject = Description = @"";
        AccountUID = ContactUID = OwnerUID = Guid.Empty;
        Status = CRMCaseStatus.New;
        Priority = ERPPriority.Normal;
        Severity = CRMCaseSeverity.Unspecified;
        Channel = CRMCaseChannel.Unspecified;
        ProductUID = CategoryUID = Guid.Empty;
        OpenedAt = DateTime.UtcNow;
        FirstResponseAt = ResolvedAt = ClosedAt = SLADueAt = null;
        IsEscalated = false;
        Resolution = @"";
        Links = new List<ERPObjectLink>(0);
        CustomFields = new List<ERPCustomField>(0);
    }

    /// <summary>Human-readable case number / reference.</summary>
    public String Reference { get; set; }

    /// <summary>Short subject.</summary>
    public String Subject { get; set; }

    /// <summary>Detailed problem description.</summary>
    public String Description { get; set; }

    /// <summary>Account the case belongs to.</summary>
    public Guid AccountUID { get; set; }

    /// <summary>Reporting contact.</summary>
    public Guid ContactUID { get; set; }

    /// <summary>Owning agent.</summary>
    public Guid OwnerUID { get; set; }

    /// <summary>Lifecycle state.</summary>
    public CRMCaseStatus Status { get; set; }

    /// <summary>Urgency on the shared ERP scale.</summary>
    public ERPPriority Priority { get; set; }

    /// <summary>Technical impact severity.</summary>
    public CRMCaseSeverity Severity { get; set; }

    /// <summary>Channel the case came in through.</summary>
    public CRMCaseChannel Channel { get; set; }

    /// <summary>Affected ERP product, if any.</summary>
    public Guid ProductUID { get; set; }

    /// <summary>Optional case category (references an <see cref="ERP.Bases.ERPCodeName"/>-style lookup).</summary>
    public Guid CategoryUID { get; set; }

    /// <summary>When the case was opened.</summary>
    public DateTime OpenedAt { get; set; }

    /// <summary>When the first response was sent.</summary>
    public DateTime? FirstResponseAt { get; set; }

    /// <summary>When the case was resolved.</summary>
    public DateTime? ResolvedAt { get; set; }

    /// <summary>When the case was closed.</summary>
    public DateTime? ClosedAt { get; set; }

    /// <summary>SLA resolution target.</summary>
    public DateTime? SLADueAt { get; set; }

    /// <summary>Whether the case has been escalated.</summary>
    public Boolean IsEscalated { get; set; }

    /// <summary>Resolution summary.</summary>
    public String Resolution { get; set; }

    /// <summary>Loose links to related objects (e.g. originating opportunity, KB articles).</summary>
    public List<ERPObjectLink> Links { get; set; }

    /// <summary>Free-form extension fields.</summary>
    public List<ERPCustomField> CustomFields { get; set; }
}
