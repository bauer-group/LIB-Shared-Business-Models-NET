using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.ERP;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// A marketing campaign. Extends <see cref="ERPCodeName"/> (Code + Name) and tracks the schedule,
/// budget, expected return and hierarchy. Members are modelled separately via
/// <see cref="CRMCampaignMember"/>.
/// </summary>
public class CRMCampaign : ERPCodeName
{
    /// <summary>Initialises a new campaign with neutral defaults.</summary>
    public CRMCampaign()
    {
        Type = CRMCampaignType.Unspecified;
        Status = CRMCampaignStatus.Planned;
        Description = @"";
        StartDate = EndDate = null;
        BudgetedCost = ActualCost = ExpectedRevenue = 0m;
        ExpectedResponseRate = 0m;
        Currency = ERPCurrency.EUR;
        ParentCampaignUID = OwnerUID = Guid.Empty;
        CustomFields = new List<ERPCustomField>(0);
        Links = new List<ERPObjectLink>(0);
    }

    /// <summary>Marketing format of the campaign.</summary>
    public CRMCampaignType Type { get; set; }

    /// <summary>Execution state.</summary>
    public CRMCampaignStatus Status { get; set; }

    /// <summary>Campaign description / objective.</summary>
    public String Description { get; set; }

    /// <summary>Scheduled start.</summary>
    public DateTime? StartDate { get; set; }

    /// <summary>Scheduled end.</summary>
    public DateTime? EndDate { get; set; }

    /// <summary>Planned budget, in <see cref="Currency"/>.</summary>
    public Decimal BudgetedCost { get; set; }

    /// <summary>Actual spend, in <see cref="Currency"/>.</summary>
    public Decimal ActualCost { get; set; }

    /// <summary>Expected revenue, in <see cref="Currency"/>.</summary>
    public Decimal ExpectedRevenue { get; set; }

    /// <summary>Expected response rate (0–100).</summary>
    public Decimal ExpectedResponseRate { get; set; }

    /// <summary>Currency of the monetary figures.</summary>
    public ERPCurrency Currency { get; set; }

    /// <summary>Parent campaign for multi-wave / nested campaigns.</summary>
    public Guid ParentCampaignUID { get; set; }

    /// <summary>Owning marketing user.</summary>
    public Guid OwnerUID { get; set; }

    /// <summary>Free-form extension fields.</summary>
    public List<ERPCustomField> CustomFields { get; set; }

    /// <summary>Loose links to related objects.</summary>
    public List<ERPObjectLink> Links { get; set; }
}
