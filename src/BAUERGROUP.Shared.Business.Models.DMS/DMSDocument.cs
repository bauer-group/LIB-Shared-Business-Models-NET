using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;
using BAUERGROUP.Shared.Business.Models.ERP;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// The logical document — the aggregate root of the DMS model. It owns its version history,
/// keywording (tags + index fields), virtual filing placements, retention, access control,
/// signatures, full-text and links. The actual bytes live on the <see cref="DMSRendition"/>s of
/// each <see cref="DMSDocumentVersion"/>; this entity holds the metadata and the pointer to the
/// current version.
/// </summary>
public class DMSDocument : DMSObjectBase
{
    /// <summary>Initialises a new document with neutral defaults, stamping <see cref="DocumentDate"/>.</summary>
    public DMSDocument()
    {
        Title = DocumentNumber = @"";
        DocumentTypeUID = Guid.Empty;
        Status = DMSDocumentStatus.Draft;
        Classification = DMSSecurityClassification.Internal;
        OwnerUID = AuthorUID = Guid.Empty;
        Language = ERPLanguage.German;
        FolderUID = Guid.Empty;
        DocumentDate = DateTime.UtcNow;
        ReceivedDate = null;
        CurrentVersionUID = Guid.Empty;
        CheckedOutByUID = Guid.Empty;
        CheckedOutAt = null;
        Tags = new List<DMSTag>(0);
        IndexFields = new List<DMSIndexField>(0);
        Versions = new List<DMSDocumentVersion>(0);
        FilingLocations = new List<DMSFilingLocation>(0);
        AccessControl = new List<DMSAccessControlEntry>(0);
        Signatures = new List<DMSSignature>(0);
        Workflows = new List<DMSWorkflow>(0);
        Deadlines = new List<DMSDeadline>(0);
        Links = new List<DMSObjectLink>(0);
        CustomFields = new List<ERPCustomField>(0);
        Retention = new DMSRetention();
        FullText = null;
    }

    /// <summary>Human-readable title.</summary>
    public String Title { get; set; }

    /// <summary>Business document number / reference.</summary>
    public String DocumentNumber { get; set; }

    /// <summary>Document type / class (references a type lookup).</summary>
    public Guid DocumentTypeUID { get; set; }

    /// <summary>Lifecycle state flags.</summary>
    public DMSDocumentStatus Status { get; set; }

    /// <summary>Security classification level.</summary>
    public DMSSecurityClassification Classification { get; set; }

    /// <summary>Owning user / responsible party.</summary>
    public Guid OwnerUID { get; set; }

    /// <summary>Original author.</summary>
    public Guid AuthorUID { get; set; }

    /// <summary>Primary document language (reuses the ERP language list).</summary>
    public ERPLanguage Language { get; set; }

    /// <summary>Primary physical/logical folder (a virtual filing placement lives in <see cref="FilingLocations"/>).</summary>
    public Guid FolderUID { get; set; }

    /// <summary>Effective document date.</summary>
    public DateTime DocumentDate { get; set; }

    /// <summary>When the document was received (for inbound mail / scans).</summary>
    public DateTime? ReceivedDate { get; set; }

    /// <summary>The active version of the document.</summary>
    public Guid CurrentVersionUID { get; set; }

    /// <summary>User holding the check-out lock (<see cref="Guid.Empty"/> if not checked out).</summary>
    public Guid CheckedOutByUID { get; set; }

    /// <summary>When the document was checked out.</summary>
    public DateTime? CheckedOutAt { get; set; }

    /// <summary>Free keywords / tags.</summary>
    public List<DMSTag> Tags { get; set; }

    /// <summary>Structured index values captured via a keywording mask (Verschlagwortung).</summary>
    public List<DMSIndexField> IndexFields { get; set; }

    /// <summary>Version history.</summary>
    public List<DMSDocumentVersion> Versions { get; set; }

    /// <summary>Virtual filing placements — a document may appear under several virtual paths.</summary>
    public List<DMSFilingLocation> FilingLocations { get; set; }

    /// <summary>Access control entries governing this document.</summary>
    public List<DMSAccessControlEntry> AccessControl { get; set; }

    /// <summary>Electronic signatures / seals applied to the document.</summary>
    public List<DMSSignature> Signatures { get; set; }

    /// <summary>Routing / approval workflows over the document (e.g. invoice approval).</summary>
    public List<DMSWorkflow> Workflows { get; set; }

    /// <summary>Deadlines and follow-ups (Fristsachen / Wiedervorlagen) on the document.</summary>
    public List<DMSDeadline> Deadlines { get; set; }

    /// <summary>Typed links to other documents and to CRM/ERP objects.</summary>
    public List<DMSObjectLink> Links { get; set; }

    /// <summary>Free-form extension fields.</summary>
    public List<ERPCustomField> CustomFields { get; set; }

    /// <summary>Retention / records-management state for the document.</summary>
    public DMSRetention Retention { get; set; }

    /// <summary>Extracted full-text / OCR content (null until extracted).</summary>
    public DMSFullTextContent FullText { get; set; }

    /// <summary>True when the document is currently checked out.</summary>
    public Boolean IsCheckedOut
    {
        get { return Status.HasFlag(DMSDocumentStatus.CheckedOut); }
    }

    /// <summary>True when the document has been archived.</summary>
    public Boolean IsArchived
    {
        get { return Status.HasFlag(DMSDocumentStatus.Archived); }
    }

    /// <summary>True when the document is flagged deleted.</summary>
    public Boolean IsDeleted
    {
        get { return Status.HasFlag(DMSDocumentStatus.Deleted); }
    }
}
