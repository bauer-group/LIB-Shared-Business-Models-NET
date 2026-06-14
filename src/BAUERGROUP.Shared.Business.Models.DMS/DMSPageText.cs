using System;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>Recognised / extracted text of a single page, with its OCR confidence.</summary>
public class DMSPageText : DMSObjectBase
{
    /// <summary>Initialises a new page-text entry with neutral defaults.</summary>
    public DMSPageText()
    {
        PageNumber = 0;
        Text = @"";
        Confidence = 0m;
    }

    /// <summary>1-based page number.</summary>
    public Int32 PageNumber { get; set; }

    /// <summary>Text content of the page.</summary>
    public String Text { get; set; }

    /// <summary>OCR confidence for the page (0–100); 100 for native extraction.</summary>
    public Decimal Confidence { get; set; }
}
