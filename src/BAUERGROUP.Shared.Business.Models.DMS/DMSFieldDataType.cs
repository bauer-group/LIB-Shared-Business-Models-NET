namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>Data type of an index (keywording) field, governing how its string value is interpreted.</summary>
public enum DMSFieldDataType
{
    /// <summary>Single-line text.</summary>
    Text = 0,
    MultilineText = 1,
    Integer = 2,
    Decimal = 3,
    Boolean = 4,
    Date = 5,
    DateTime = 6,
    Picklist = 7,
    PartyReference = 8,
    DocumentReference = 9,
    Currency = 10,
    Url = 11,
    /// <summary>A type that does not fit the predefined set.</summary>
    Other = 9999
}
