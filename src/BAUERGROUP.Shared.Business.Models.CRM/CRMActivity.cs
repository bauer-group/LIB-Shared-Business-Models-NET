using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.CRM.Bases;
using BAUERGROUP.Shared.Business.Models.ERP;

namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// A single interaction — call, meeting, email, task, note or letter — that forms the engagement
/// history. The subject it concerns is addressed polymorphically through
/// <see cref="RegardingUID"/> + <see cref="RegardingType"/>, so one activity type can hang off an
/// account, contact, lead, opportunity or case. Priority reuses the ERP <see cref="ERPPriority"/>
/// scale.
/// </summary>
public class CRMActivity : CRMObjectBase
{
    /// <summary>Initialises a new activity with neutral defaults.</summary>
    public CRMActivity()
    {
        Type = CRMActivityType.Task;
        Subject = Body = @"";
        Direction = CRMActivityDirection.Unspecified;
        Status = CRMActivityStatus.Open;
        Priority = ERPPriority.Normal;
        StartDate = EndDate = DueDate = CompletedAt = null;
        DurationMinutes = 0;
        OwnerUID = Guid.Empty;
        RegardingUID = Guid.Empty;
        RegardingType = CRMReferenceType.Unspecified;
        Location = Outcome = @"";
        Participants = new List<Guid>(0);
        Links = new List<ERPObjectLink>(0);
    }

    /// <summary>Kind of interaction.</summary>
    public CRMActivityType Type { get; set; }

    /// <summary>Short subject line.</summary>
    public String Subject { get; set; }

    /// <summary>Body / notes of the interaction.</summary>
    public String Body { get; set; }

    /// <summary>Inbound or outbound direction (for communication types).</summary>
    public CRMActivityDirection Direction { get; set; }

    /// <summary>Completion state.</summary>
    public CRMActivityStatus Status { get; set; }

    /// <summary>Priority on the shared ERP scale.</summary>
    public ERPPriority Priority { get; set; }

    /// <summary>Scheduled start.</summary>
    public DateTime? StartDate { get; set; }

    /// <summary>Scheduled end.</summary>
    public DateTime? EndDate { get; set; }

    /// <summary>Due date for task-like activities.</summary>
    public DateTime? DueDate { get; set; }

    /// <summary>When the activity was completed.</summary>
    public DateTime? CompletedAt { get; set; }

    /// <summary>Duration in minutes (e.g. call length).</summary>
    public Int32 DurationMinutes { get; set; }

    /// <summary>Owning user.</summary>
    public Guid OwnerUID { get; set; }

    /// <summary>Id of the subject the activity concerns.</summary>
    public Guid RegardingUID { get; set; }

    /// <summary>Type of the subject referenced by <see cref="RegardingUID"/>.</summary>
    public CRMReferenceType RegardingType { get; set; }

    /// <summary>Physical or virtual location (for meetings / appointments).</summary>
    public String Location { get; set; }

    /// <summary>Recorded outcome / result.</summary>
    public String Outcome { get; set; }

    /// <summary>Participating contacts / users, referenced by id.</summary>
    public List<Guid> Participants { get; set; }

    /// <summary>Loose links to related objects.</summary>
    public List<ERPObjectLink> Links { get; set; }
}
