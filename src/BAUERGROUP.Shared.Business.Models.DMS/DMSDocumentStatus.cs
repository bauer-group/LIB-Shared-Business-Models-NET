using System;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// Lifecycle state of a document, modelled as flags so combinations such as
/// "Released | CheckedOut" are expressible.
/// </summary>
[Flags]
public enum DMSDocumentStatus
{
    /// <summary>No state set.</summary>
    None = 0,
    Draft = 1,
    InReview = 2,
    Approved = 4,
    Released = 8,
    CheckedOut = 16,
    Locked = 32,
    Archived = 64,
    Obsolete = 128,
    Deleted = 256
}
