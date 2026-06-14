namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>Processing state of an OCR job for a document.</summary>
public enum DMSOcrStatus
{
    /// <summary>The document is natively text-bearing; OCR does not apply.</summary>
    NotApplicable = 0,
    Pending = 1,
    Processing = 2,
    Completed = 3,
    Failed = 4
}
