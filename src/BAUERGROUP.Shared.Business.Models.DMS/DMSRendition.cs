using System;
using BAUERGROUP.Shared.Business.Models.ERP;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// A concrete byte representation of a document version. Extends <see cref="ERPAttachment"/>, so it
/// inherits the polymorphic payload (a file path, an embedded <c>byte[]</c> or a <c>Uri</c> plus the
/// <c>Mode</c> discriminator and <c>Language</c>) and adds DMS rendition metadata: its role, format,
/// PDF/A conformance, MIME type, integrity hash, size and page count.
/// </summary>
public class DMSRendition : ERPAttachment
{
    /// <summary>Initialises a new rendition, stamping <see cref="CreatedAt"/> with the current UTC time.</summary>
    public DMSRendition()
    {
        RenditionType = DMSRenditionType.Original;
        Format = DMSRenditionFormat.Unspecified;
        PDFALevel = DMSPDFALevel.None;
        MimeType = @"";
        Hash = @"";
        FileSize = 0L;
        PageCount = 0;
        CreatedAt = DateTime.UtcNow;
    }

    /// <summary>Role this rendition plays (original, archive, preview …).</summary>
    public DMSRenditionType RenditionType { get; set; }

    /// <summary>File format of the payload.</summary>
    public DMSRenditionFormat Format { get; set; }

    /// <summary>PDF/A conformance level (when this is a PDF/A archival rendition).</summary>
    public DMSPDFALevel PDFALevel { get; set; }

    /// <summary>MIME / media type, e.g. <c>application/pdf</c>.</summary>
    public String MimeType { get; set; }

    /// <summary>Content integrity hash (hex), paired with the hashing algorithm used.</summary>
    public String Hash { get; set; }

    /// <summary>Payload size in bytes.</summary>
    public Int64 FileSize { get; set; }

    /// <summary>Number of pages (for paginated formats).</summary>
    public Int32 PageCount { get; set; }

    /// <summary>When the rendition was produced.</summary>
    public DateTime CreatedAt { get; set; }
}
