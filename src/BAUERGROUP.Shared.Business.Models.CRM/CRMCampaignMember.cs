using System;
using BAUERGROUP.Shared.Business.Models.CRM.Bases;

namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// Associates a contact or lead with a campaign and tracks its response. <see cref="MemberType"/>
/// discriminates whether <see cref="MemberUID"/> points at a <see cref="CRMContact"/> or a
/// <see cref="CRMLead"/>.
/// </summary>
public class CRMCampaignMember : CRMObjectBase
{
    /// <summary>Initialises a new membership with neutral defaults.</summary>
    public CRMCampaignMember()
    {
        CampaignUID = Guid.Empty;
        MemberUID = Guid.Empty;
        MemberType = CRMReferenceType.Contact;
        Status = CRMCampaignMemberStatus.Targeted;
        RespondedAt = null;
        HasResponded = false;
    }

    /// <summary>The campaign this membership belongs to.</summary>
    public Guid CampaignUID { get; set; }

    /// <summary>The contact or lead being targeted.</summary>
    public Guid MemberUID { get; set; }

    /// <summary>Whether <see cref="MemberUID"/> is a contact or a lead.</summary>
    public CRMReferenceType MemberType { get; set; }

    /// <summary>Current response state.</summary>
    public CRMCampaignMemberStatus Status { get; set; }

    /// <summary>When the member responded, if they did.</summary>
    public DateTime? RespondedAt { get; set; }

    /// <summary>Convenience flag mirroring a responded/converted <see cref="Status"/>.</summary>
    public Boolean HasResponded { get; set; }
}
