using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;
using BAUERGROUP.Shared.Business.Models.ERP;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// A routing / approval workflow run over a document — review, release, distribution, signature or
/// invoice approval (Rechnungsfreigabe). Holds the ordered approval <see cref="Steps"/>, the
/// evaluation mode and the overall status. When the document mirrors an ERP invoice, link the two
/// by id via a <see cref="DMSObjectLink"/> with <see cref="DMSLinkDomain.ERP"/>.
/// </summary>
public class DMSWorkflow : DMSObjectBase
{
    /// <summary>Initialises a new, not-yet-started sequential approval workflow.</summary>
    public DMSWorkflow()
    {
        DocumentUID = Guid.Empty;
        Name = @"";
        Type = DMSWorkflowType.Approval;
        Status = DMSWorkflowStatus.NotStarted;
        Mode = DMSWorkflowMode.Sequential;
        InitiatorUID = Guid.Empty;
        StartedAt = CompletedAt = DueDate = null;
        CurrentStepOrder = 0;
        Steps = new List<DMSWorkflowStep>(0);
        Links = new List<DMSObjectLink>(0);
        CustomFields = new List<ERPCustomField>(0);
    }

    /// <summary>The document being routed.</summary>
    public Guid DocumentUID { get; set; }

    /// <summary>Workflow name / title.</summary>
    public String Name { get; set; }

    /// <summary>Kind of workflow (approval, review, invoice approval …).</summary>
    public DMSWorkflowType Type { get; set; }

    /// <summary>Overall state.</summary>
    public DMSWorkflowStatus Status { get; set; }

    /// <summary>How steps are evaluated (sequential, parallel, any-one).</summary>
    public DMSWorkflowMode Mode { get; set; }

    /// <summary>User who started the workflow.</summary>
    public Guid InitiatorUID { get; set; }

    /// <summary>When the workflow started.</summary>
    public DateTime? StartedAt { get; set; }

    /// <summary>When the workflow finished.</summary>
    public DateTime? CompletedAt { get; set; }

    /// <summary>Overall due date for the routing.</summary>
    public DateTime? DueDate { get; set; }

    /// <summary>Order of the step currently awaiting action (for sequential mode).</summary>
    public Int32 CurrentStepOrder { get; set; }

    /// <summary>Ordered approval steps.</summary>
    public List<DMSWorkflowStep> Steps { get; set; }

    /// <summary>Loose links to related objects (e.g. the ERP invoice being approved).</summary>
    public List<DMSObjectLink> Links { get; set; }

    /// <summary>Free-form extension fields.</summary>
    public List<ERPCustomField> CustomFields { get; set; }

    /// <summary>True once the workflow has reached a terminal state.</summary>
    public Boolean IsComplete
    {
        get
        {
            return Status == DMSWorkflowStatus.Approved
                || Status == DMSWorkflowStatus.Rejected
                || Status == DMSWorkflowStatus.Canceled;
        }
    }
}
