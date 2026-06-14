using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.CRM.Bases;
using BAUERGROUP.Shared.Business.Models.ERP;

namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// A potential deal in the sales pipeline. References its account, primary contact, owner and
/// pipeline stage by id, carries the monetary value and probability, and optionally itemises the
/// products quoted (each line referencing an <see cref="ERPProduct"/> by id).
/// </summary>
public class CRMOpportunity : CRMObjectBase
{
    /// <summary>Initialises a new opportunity with neutral defaults.</summary>
    public CRMOpportunity()
    {
        Name = Description = @"";
        AccountUID = Guid.Empty;
        PrimaryContactUID = Guid.Empty;
        OwnerUID = Guid.Empty;
        StageUID = Guid.Empty;
        Status = CRMOpportunityStatus.Open;
        ForecastCategory = CRMForecastCategory.Pipeline;
        Source = CRMSource.Unspecified;
        Amount = 0m;
        Currency = ERPCurrency.EUR;
        Probability = 0m;
        ExpectedCloseDate = null;
        ActualCloseDate = null;
        LostReason = CRMLostReason.Unspecified;
        LostReasonDetail = @"";
        CampaignUID = Guid.Empty;
        Lines = new List<CRMOpportunityLine>(0);
        CustomFields = new List<ERPCustomField>(0);
        Links = new List<ERPObjectLink>(0);
    }

    /// <summary>Short title of the opportunity.</summary>
    public String Name { get; set; }

    /// <summary>Longer description / notes.</summary>
    public String Description { get; set; }

    /// <summary>Account the deal is with.</summary>
    public Guid AccountUID { get; set; }

    /// <summary>Primary contact driving the deal.</summary>
    public Guid PrimaryContactUID { get; set; }

    /// <summary>Owning sales user.</summary>
    public Guid OwnerUID { get; set; }

    /// <summary>Current pipeline stage (references a <see cref="CRMPipelineStage"/>).</summary>
    public Guid StageUID { get; set; }

    /// <summary>Resolution state (open / won / lost / abandoned).</summary>
    public CRMOpportunityStatus Status { get; set; }

    /// <summary>Forecast bucket the opportunity contributes to.</summary>
    public CRMForecastCategory ForecastCategory { get; set; }

    /// <summary>Origin channel of the opportunity.</summary>
    public CRMSource Source { get; set; }

    /// <summary>Deal value, in <see cref="Currency"/>.</summary>
    public Decimal Amount { get; set; }

    /// <summary>Currency of <see cref="Amount"/>.</summary>
    public ERPCurrency Currency { get; set; }

    /// <summary>Win probability (0–100).</summary>
    public Decimal Probability { get; set; }

    /// <summary>Expected close date.</summary>
    public DateTime? ExpectedCloseDate { get; set; }

    /// <summary>Actual close date once resolved.</summary>
    public DateTime? ActualCloseDate { get; set; }

    /// <summary>Categorised loss reason (when <see cref="Status"/> is lost).</summary>
    public CRMLostReason LostReason { get; set; }

    /// <summary>Free-text loss detail.</summary>
    public String LostReasonDetail { get; set; }

    /// <summary>Originating marketing campaign, if any.</summary>
    public Guid CampaignUID { get; set; }

    /// <summary>Quoted product lines.</summary>
    public List<CRMOpportunityLine> Lines { get; set; }

    /// <summary>Free-form extension fields.</summary>
    public List<ERPCustomField> CustomFields { get; set; }

    /// <summary>Loose links to related objects.</summary>
    public List<ERPObjectLink> Links { get; set; }

    /// <summary>Probability-weighted value (<see cref="Amount"/> × <see cref="Probability"/> / 100).</summary>
    public Decimal WeightedAmount
    {
        get { return Amount * (Probability / 100m); }
    }
}
