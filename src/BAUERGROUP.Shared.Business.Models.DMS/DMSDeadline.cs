using System;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;
using BAUERGROUP.Shared.Business.Models.ERP;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// A deadline or follow-up on a document (Fristsache) — a bring-forward / resubmission
/// (Wiedervorlage), a hard deadline, a renewal or an expiry. Carries the due date, an optional
/// reminder, the responsible principal and the handling status, with priority on the shared ERP
/// scale.
/// </summary>
public class DMSDeadline : DMSObjectBase
{
    /// <summary>Initialises a new open resubmission due now (callers set the real due date).</summary>
    public DMSDeadline()
    {
        DocumentUID = Guid.Empty;
        Type = DMSDeadlineType.Resubmission;
        Subject = Description = @"";
        DueDate = DateTime.UtcNow;
        ReminderDate = null;
        ResponsibleUID = Guid.Empty;
        Status = DMSDeadlineStatus.Open;
        Priority = ERPPriority.Normal;
        CompletedAt = null;
        CompletedByUID = Guid.Empty;
        IsRecurring = false;
        EscalationUID = Guid.Empty;
    }

    /// <summary>The document the deadline is attached to.</summary>
    public Guid DocumentUID { get; set; }

    /// <summary>Kind of deadline (resubmission, hard deadline, renewal …).</summary>
    public DMSDeadlineType Type { get; set; }

    /// <summary>Short subject.</summary>
    public String Subject { get; set; }

    /// <summary>Detail / instructions.</summary>
    public String Description { get; set; }

    /// <summary>When the deadline falls due.</summary>
    public DateTime DueDate { get; set; }

    /// <summary>When to remind ahead of the due date.</summary>
    public DateTime? ReminderDate { get; set; }

    /// <summary>The responsible principal.</summary>
    public Guid ResponsibleUID { get; set; }

    /// <summary>Handling status.</summary>
    public DMSDeadlineStatus Status { get; set; }

    /// <summary>Priority on the shared ERP scale.</summary>
    public ERPPriority Priority { get; set; }

    /// <summary>When the deadline was completed.</summary>
    public DateTime? CompletedAt { get; set; }

    /// <summary>Who completed it.</summary>
    public Guid CompletedByUID { get; set; }

    /// <summary>Whether the deadline recurs (e.g. a periodic review).</summary>
    public Boolean IsRecurring { get; set; }

    /// <summary>Principal to escalate to if the deadline is missed.</summary>
    public Guid EscalationUID { get; set; }
}
