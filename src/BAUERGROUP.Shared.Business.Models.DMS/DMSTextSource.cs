namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>How the full-text content of a document was obtained.</summary>
public enum DMSTextSource
{
    /// <summary>Source not recorded.</summary>
    Unspecified = 0,
    /// <summary>Extracted from a natively text-bearing format (e.g. PDF text layer, DOCX).</summary>
    Native = 1,
    /// <summary>Recognised from an image via OCR.</summary>
    OCR = 2,
    /// <summary>Entered or corrected manually.</summary>
    Manual = 3
}
