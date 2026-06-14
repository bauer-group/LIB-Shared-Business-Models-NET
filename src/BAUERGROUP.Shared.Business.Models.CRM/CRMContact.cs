using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.ERP;

namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// An individual person tracked in the CRM. Extends <see cref="ERPAddress"/> for the postal and
/// communication surface (Name, Address, ZIP, City, Country, EMail, Phone, Mobile, Fax) and adds
/// the person-level CRM attributes plus the link to the owning account.
/// </summary>
/// <remarks>
/// The CRM engagement state is exposed as <see cref="ContactStatus"/> — deliberately not
/// <c>Status</c>, which is the inherited <see cref="ERPAddress"/> address status.
/// </remarks>
public class CRMContact : ERPAddress
{
    /// <summary>Initialises a new contact with neutral defaults.</summary>
    public CRMContact()
    {
        AccountUID = Guid.Empty;
        FirstName = LastName = @"";
        JobTitle = Department = @"";
        IsPrimary = false;
        Birthday = null;
        OwnerUID = Guid.Empty;
        ContactStatus = CRMContactStatus.Active;
        Consent = CRMConsentStatus.Unknown;
        Source = CRMSource.Unspecified;
        CustomFields = new List<ERPCustomField>(0);
        Links = new List<ERPObjectLink>(0);
    }

    /// <summary>Account this person belongs to (<see cref="Guid.Empty"/> if unaffiliated).</summary>
    public Guid AccountUID { get; set; }

    /// <summary>Given name.</summary>
    public String FirstName { get; set; }

    /// <summary>Family name.</summary>
    public String LastName { get; set; }

    /// <summary>Job title / position.</summary>
    public String JobTitle { get; set; }

    /// <summary>Organizational department.</summary>
    public String Department { get; set; }

    /// <summary>Whether this is the primary contact for the account.</summary>
    public Boolean IsPrimary { get; set; }

    /// <summary>Date of birth, if known.</summary>
    public DateTime? Birthday { get; set; }

    /// <summary>Owning user / account manager, referenced by id.</summary>
    public Guid OwnerUID { get; set; }

    /// <summary>CRM engagement state of the contact.</summary>
    public CRMContactStatus ContactStatus { get; set; }

    /// <summary>GDPR / marketing consent state.</summary>
    public CRMConsentStatus Consent { get; set; }

    /// <summary>Origin channel the contact was acquired through.</summary>
    public CRMSource Source { get; set; }

    /// <summary>Free-form extension fields.</summary>
    public List<ERPCustomField> CustomFields { get; set; }

    /// <summary>Loose links to related objects.</summary>
    public List<ERPObjectLink> Links { get; set; }
}
