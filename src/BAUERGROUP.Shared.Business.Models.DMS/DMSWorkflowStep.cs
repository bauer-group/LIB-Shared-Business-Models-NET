using System;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// One step of a document workflow: an approver (user, group or role) and the decision they
/// record. Steps are ordered for sequential routing; <see cref="IsMandatory"/> and
/// <see cref="EscalationUID"/> support optional approvers and escalation on timeout.
/// </summary>
public class DMSWorkflowStep : DMSObjectBase
{
    /// <summary>Initialises a new, as-yet-undecided step assigned to a user.</summary>
    public DMSWorkflowStep()
    {
        Order = 0;
        Name = Comment = AssigneeName = @"";
        AssigneeUID = Guid.Empty;
        AssigneeType = DMSPrincipalType.User;
        Decision = DMSApprovalDecision.Pending;
        DecidedByUID = Guid.Empty;
        DecisionAt = null;
        DueDate = null;
        IsMandatory = true;
        EscalationUID = Guid.Empty;
    }

    /// <summary>Position of the step in the routing order (ascending).</summary>
    public Int32 Order { get; set; }

    /// <summary>Step name / label.</summary>
    public String Name { get; set; }

    /// <summary>The assigned approver principal.</summary>
    public Guid AssigneeUID { get; set; }

    /// <summary>Whether the assignee is a user, group or role.</summary>
    public DMSPrincipalType AssigneeType { get; set; }

    /// <summary>Assignee display name snapshot.</summary>
    public String AssigneeName { get; set; }

    /// <summary>The recorded decision.</summary>
    public DMSApprovalDecision Decision { get; set; }

    /// <summary>The principal who actually decided (e.g. after delegation).</summary>
    public Guid DecidedByUID { get; set; }

    /// <summary>When the decision was made.</summary>
    public DateTime? DecisionAt { get; set; }

    /// <summary>Approver's comment / rationale.</summary>
    public String Comment { get; set; }

    /// <summary>Per-step due date.</summary>
    public DateTime? DueDate { get; set; }

    /// <summary>Whether the step must decide for the workflow to complete.</summary>
    public Boolean IsMandatory { get; set; }

    /// <summary>Principal to escalate to if the step times out (<see cref="Guid.Empty"/> if none).</summary>
    public Guid EscalationUID { get; set; }
}
