namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>File format of a rendition payload.</summary>
public enum DMSRenditionFormat
{
    /// <summary>Format not set.</summary>
    Unspecified = 0,
    PDF = 1,
    PDFA = 2,
    TIFF = 3,
    PNG = 4,
    JPEG = 5,
    BMP = 6,
    GIF = 7,
    DOCX = 8,
    XLSX = 9,
    PPTX = 10,
    TXT = 11,
    XML = 12,
    EML = 13,
    MSG = 14,
    ZIP = 15,
    /// <summary>A format that does not fit the predefined set.</summary>
    Other = 9999
}
