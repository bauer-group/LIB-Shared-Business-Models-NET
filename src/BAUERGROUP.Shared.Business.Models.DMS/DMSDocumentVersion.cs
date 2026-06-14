using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// One immutable version of a document. Carries its own renditions (original + PDF/A archive +
/// preview/thumbnail/text), the authoring metadata and the version number. The owning
/// <see cref="DMSDocument"/> points at the active version through its <c>CurrentVersionUID</c>.
/// </summary>
public class DMSDocumentVersion : DMSObjectBase
{
    /// <summary>Initialises a new version (1.0), stamping <see cref="CreatedAt"/> with the current UTC time.</summary>
    public DMSDocumentVersion()
    {
        DocumentUID = Guid.Empty;
        VersionLabel = @"";
        MajorVersion = 1;
        MinorVersion = 0;
        Comment = @"";
        AuthorUID = Guid.Empty;
        CreatedAt = DateTime.UtcNow;
        IsCurrent = false;
        Renditions = new List<DMSRendition>(0);
    }

    /// <summary>The document this version belongs to.</summary>
    public Guid DocumentUID { get; set; }

    /// <summary>Display label, e.g. <c>"1.0"</c> or <c>"2.3"</c>.</summary>
    public String VersionLabel { get; set; }

    /// <summary>Major version component.</summary>
    public Int32 MajorVersion { get; set; }

    /// <summary>Minor version component.</summary>
    public Int32 MinorVersion { get; set; }

    /// <summary>Check-in comment describing what changed.</summary>
    public String Comment { get; set; }

    /// <summary>Author of this version.</summary>
    public Guid AuthorUID { get; set; }

    /// <summary>When the version was created.</summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>Whether this is the current/active version of the document.</summary>
    public Boolean IsCurrent { get; set; }

    /// <summary>Byte representations of this version.</summary>
    public List<DMSRendition> Renditions { get; set; }
}
