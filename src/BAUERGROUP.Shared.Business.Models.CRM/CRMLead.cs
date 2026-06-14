using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.ERP;

namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// An unqualified prospect. Extends <see cref="ERPAddress"/> for name and contact channels and
/// captures the qualification state plus the conversion targets the lead resolves into.
/// </summary>
/// <remarks>
/// The qualification state is <see cref="LeadStatus"/> — not <c>Status</c>, which is the inherited
/// <see cref="ERPAddress"/> address status.
/// </remarks>
public class CRMLead : ERPAddress
{
    /// <summary>Initialises a new lead with neutral defaults.</summary>
    public CRMLead()
    {
        Company = @"";
        FirstName = LastName = JobTitle = @"";
        Source = CRMSource.Unspecified;
        LeadStatus = CRMLeadStatus.New;
        Rating = CRMRating.Unspecified;
        Consent = CRMConsentStatus.Unknown;
        OwnerUID = Guid.Empty;
        EstimatedValue = 0m;
        Currency = ERPCurrency.EUR;
        ConvertedAccountUID = Guid.Empty;
        ConvertedContactUID = Guid.Empty;
        ConvertedOpportunityUID = Guid.Empty;
        ConvertedAt = null;
        CustomFields = new List<ERPCustomField>(0);
        Links = new List<ERPObjectLink>(0);
    }

    /// <summary>Company / organization the lead is associated with.</summary>
    public String Company { get; set; }

    /// <summary>Given name.</summary>
    public String FirstName { get; set; }

    /// <summary>Family name.</summary>
    public String LastName { get; set; }

    /// <summary>Job title / position.</summary>
    public String JobTitle { get; set; }

    /// <summary>Origin channel the lead came in through.</summary>
    public CRMSource Source { get; set; }

    /// <summary>Qualification state of the lead.</summary>
    public CRMLeadStatus LeadStatus { get; set; }

    /// <summary>Qualitative interest rating.</summary>
    public CRMRating Rating { get; set; }

    /// <summary>GDPR / marketing consent state.</summary>
    public CRMConsentStatus Consent { get; set; }

    /// <summary>Owning user, referenced by id.</summary>
    public Guid OwnerUID { get; set; }

    /// <summary>Estimated deal value, in <see cref="Currency"/>.</summary>
    public Decimal EstimatedValue { get; set; }

    /// <summary>Currency of <see cref="EstimatedValue"/>.</summary>
    public ERPCurrency Currency { get; set; }

    /// <summary>Account created on conversion (<see cref="Guid.Empty"/> until converted).</summary>
    public Guid ConvertedAccountUID { get; set; }

    /// <summary>Contact created on conversion.</summary>
    public Guid ConvertedContactUID { get; set; }

    /// <summary>Opportunity created on conversion.</summary>
    public Guid ConvertedOpportunityUID { get; set; }

    /// <summary>When the lead was converted, if it has been.</summary>
    public DateTime? ConvertedAt { get; set; }

    /// <summary>Free-form extension fields.</summary>
    public List<ERPCustomField> CustomFields { get; set; }

    /// <summary>Loose links to related objects.</summary>
    public List<ERPObjectLink> Links { get; set; }
}
