using System;
using BAUERGROUP.Shared.Business.Models.CRM.Bases;
using BAUERGROUP.Shared.Business.Models.ERP;

namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// A quoted product line on an opportunity. References an <see cref="ERPProduct"/> by id rather
/// than embedding it, so the CRM stays loosely coupled to the ERP product master. The line-total
/// formula mirrors the ERP document-line convention.
/// </summary>
public class CRMOpportunityLine : CRMObjectBase
{
    /// <summary>Initialises a new line with neutral defaults.</summary>
    public CRMOpportunityLine()
    {
        ProductUID = Guid.Empty;
        ProductReference = Description = @"";
        Quantity = 1m;
        UnitPrice = 0m;
        Rebate = 0m;
        Currency = ERPCurrency.EUR;
    }

    /// <summary>Referenced ERP product (<see cref="Guid.Empty"/> for a free-text line).</summary>
    public Guid ProductUID { get; set; }

    /// <summary>Product reference / SKU snapshot.</summary>
    public String ProductReference { get; set; }

    /// <summary>Line description.</summary>
    public String Description { get; set; }

    /// <summary>Quantity quoted.</summary>
    public Decimal Quantity { get; set; }

    /// <summary>Unit price, in <see cref="Currency"/>.</summary>
    public Decimal UnitPrice { get; set; }

    /// <summary>Discount percentage applied to the line (0–100).</summary>
    public Decimal Rebate { get; set; }

    /// <summary>Currency of <see cref="UnitPrice"/>.</summary>
    public ERPCurrency Currency { get; set; }

    /// <summary>Net line total (<c>Quantity × UnitPrice × (100 − Rebate) / 100</c>).</summary>
    public Decimal TotalPrice
    {
        get { return Quantity * UnitPrice * ((100m - Rebate) / 100m); }
    }
}
