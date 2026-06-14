using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;
using BAUERGROUP.Shared.Business.Models.ERP;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// Extracted full-text content of a document, feeding the full-text index (Volltextindex). Holds
/// the concatenated text plus per-page detail, and records whether it came from a native text layer
/// or OCR, the recognising engine and an aggregate confidence.
/// </summary>
public class DMSFullTextContent : DMSObjectBase
{
    /// <summary>Initialises a new full-text record, stamping <see cref="ExtractedAt"/>.</summary>
    public DMSFullTextContent()
    {
        DocumentUID = Guid.Empty;
        VersionUID = Guid.Empty;
        Text = @"";
        Language = ERPLanguage.German;
        Source = DMSTextSource.Native;
        OcrStatus = DMSOcrStatus.NotApplicable;
        OcrEngine = @"";
        OcrConfidence = 0m;
        ExtractedAt = DateTime.UtcNow;
        IsIndexed = false;
        Pages = new List<DMSPageText>(0);
    }

    /// <summary>The document the text belongs to.</summary>
    public Guid DocumentUID { get; set; }

    /// <summary>The specific version the text was extracted from.</summary>
    public Guid VersionUID { get; set; }

    /// <summary>Concatenated full text.</summary>
    public String Text { get; set; }

    /// <summary>Detected content language (reuses the ERP language list).</summary>
    public ERPLanguage Language { get; set; }

    /// <summary>Whether the text is native, OCR-derived or manual.</summary>
    public DMSTextSource Source { get; set; }

    /// <summary>OCR processing state (when applicable).</summary>
    public DMSOcrStatus OcrStatus { get; set; }

    /// <summary>Name/version of the OCR engine used.</summary>
    public String OcrEngine { get; set; }

    /// <summary>Aggregate OCR confidence (0–100).</summary>
    public Decimal OcrConfidence { get; set; }

    /// <summary>When the text was extracted.</summary>
    public DateTime ExtractedAt { get; set; }

    /// <summary>Whether the text has been pushed to the search index.</summary>
    public Boolean IsIndexed { get; set; }

    /// <summary>Per-page text detail.</summary>
    public List<DMSPageText> Pages { get; set; }
}
