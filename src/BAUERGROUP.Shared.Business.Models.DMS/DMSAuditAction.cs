namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>The action recorded by an audit-trail entry.</summary>
public enum DMSAuditAction
{
    /// <summary>Action not specified.</summary>
    Unspecified = 0,
    Created = 1,
    Viewed = 2,
    Edited = 3,
    Versioned = 4,
    Moved = 5,
    Renamed = 6,
    Classified = 7,
    Indexed = 8,
    Exported = 9,
    Printed = 10,
    Downloaded = 11,
    SignatureApplied = 12,
    RetentionChanged = 13,
    AccessChanged = 14,
    Deleted = 15,
    Restored = 16,
    AccessDenied = 17,
    /// <summary>An action that does not fit the predefined set.</summary>
    Other = 9999
}
