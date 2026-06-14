namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>Semantic type of a link from a document to another object.</summary>
public enum DMSLinkType
{
    /// <summary>Generic relation.</summary>
    Unspecified = 0,
    RelatedTo = 1,
    Supersedes = 2,
    SupersededBy = 3,
    DerivedFrom = 4,
    Attachment = 5,
    ResponseTo = 6,
    ParentOf = 7,
    ChildOf = 8,
    References = 9,
    /// <summary>A relation that does not fit the predefined set.</summary>
    Other = 9999
}
