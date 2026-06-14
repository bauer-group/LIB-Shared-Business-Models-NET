namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// Role a rendition plays for its version. A version typically has an <see cref="Original"/>, an
/// <see cref="Archive"/> (PDF/A) long-term copy, a <see cref="Preview"/> and a
/// <see cref="Thumbnail"/>, plus an extracted <see cref="Text"/> layer.
/// </summary>
public enum DMSRenditionType
{
    /// <summary>Role not set.</summary>
    Unspecified = 0,
    Original = 1,
    Archive = 2,
    Preview = 3,
    Thumbnail = 4,
    Text = 5,
    /// <summary>A rendition role that does not fit the predefined set.</summary>
    Other = 9999
}
