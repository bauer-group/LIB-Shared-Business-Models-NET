namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>Kind of routing / approval workflow run over a document.</summary>
public enum DMSWorkflowType
{
    /// <summary>Type not set.</summary>
    Unspecified = 0,
    /// <summary>Generic approval routing.</summary>
    Approval = 1,
    Review = 2,
    Release = 3,
    Distribution = 4,
    Signature = 5,
    /// <summary>Invoice approval (Rechnungsfreigabe).</summary>
    InvoiceApproval = 6,
    /// <summary>A workflow that does not fit the predefined set.</summary>
    Other = 9999
}
