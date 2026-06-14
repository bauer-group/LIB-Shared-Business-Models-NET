using System;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// A typed, cross-domain link from a document to another object. Mirrors the ERP object-link
/// pattern (type + referral id) and adds a <see cref="ReferralDomain"/>, so a document can point at
/// another DMS document, a CRM party or an ERP transaction by id alone — keeping the package
/// dependency-light while still expressing the relationship.
/// </summary>
public class DMSObjectLink : DMSObjectBase
{
    /// <summary>Initialises a new link defaulting to a same-domain "related to" relation.</summary>
    public DMSObjectLink()
    {
        Type = DMSLinkType.RelatedTo;
        ReferralUID = Guid.Empty;
        ReferralDomain = DMSLinkDomain.DMS;
        Comment = @"";
    }

    /// <summary>Semantic relation type.</summary>
    public DMSLinkType Type { get; set; }

    /// <summary>Id of the linked object.</summary>
    public Guid ReferralUID { get; set; }

    /// <summary>Domain the linked object lives in.</summary>
    public DMSLinkDomain ReferralDomain { get; set; }

    /// <summary>Optional note describing the link.</summary>
    public String Comment { get; set; }
}
