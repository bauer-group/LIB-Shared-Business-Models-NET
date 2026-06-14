namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// PDF/A conformance level of an archival rendition (ISO 19005). Captures the long-term
/// preservation guarantee required for GoBD-compliant archiving.
/// </summary>
public enum DMSPDFALevel
{
    /// <summary>Not a PDF/A rendition.</summary>
    None = 0,
    PDF_A_1a = 1,
    PDF_A_1b = 2,
    PDF_A_2a = 3,
    PDF_A_2b = 4,
    PDF_A_2u = 5,
    PDF_A_3a = 6,
    PDF_A_3b = 7,
    PDF_A_3u = 8
}
