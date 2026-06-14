using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.ERP;

namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// A company / organization tracked in the CRM. Extends <see cref="ERPBusinessAssociate"/>, so it
/// carries the full party surface — address, contact channels, currency, language, VAT/tax ids,
/// bank accounts, payment terms, commercial representative, custom fields and attachments — and
/// adds the CRM-specific relationship attributes on top.
/// </summary>
public class CRMAccount : ERPBusinessAssociate
{
    /// <summary>Initialises a new account with neutral defaults.</summary>
    public CRMAccount()
    {
        Industry = CRMIndustry.Unspecified;
        AccountType = CRMAccountType.Unspecified;
        Rating = CRMRating.Unspecified;
        LifecycleStage = CRMLifecycleStage.Unspecified;
        Source = CRMSource.Unspecified;
        ParentAccountUID = Guid.Empty;
        OwnerUID = Guid.Empty;
        AnnualRevenue = 0m;
        EmployeeCount = 0;
        Links = new List<ERPObjectLink>(0);
    }

    /// <summary>Primary industry sector of the account.</summary>
    public CRMIndustry Industry { get; set; }

    /// <summary>CRM relationship classification (prospect, customer, partner …).</summary>
    public CRMAccountType AccountType { get; set; }

    /// <summary>Qualitative engagement rating.</summary>
    public CRMRating Rating { get; set; }

    /// <summary>Marketing / sales lifecycle stage of the account.</summary>
    public CRMLifecycleStage LifecycleStage { get; set; }

    /// <summary>Origin channel the account was acquired through.</summary>
    public CRMSource Source { get; set; }

    /// <summary>Parent account for corporate hierarchies (<see cref="Guid.Empty"/> if top-level).</summary>
    public Guid ParentAccountUID { get; set; }

    /// <summary>Owning user / account manager, referenced by id.</summary>
    public Guid OwnerUID { get; set; }

    /// <summary>Reported annual revenue, expressed in the account's inherited <c>Currency</c>.</summary>
    public Decimal AnnualRevenue { get; set; }

    /// <summary>Approximate number of employees.</summary>
    public Int32 EmployeeCount { get; set; }

    /// <summary>Loose links to related objects (other accounts, ERP documents, …).</summary>
    public List<ERPObjectLink> Links { get; set; }
}
