using System;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// An actual index value captured on a document (the result of keywording / Verschlagwortung). The
/// value is stored as a string; <see cref="DataType"/> indicates how to interpret it, mirroring the
/// originating <see cref="DMSIndexFieldDefinition"/>.
/// </summary>
public class DMSIndexField : DMSObjectBase
{
    /// <summary>Initialises a new index value with neutral defaults.</summary>
    public DMSIndexField()
    {
        FieldCode = Caption = @"";
        DataType = DMSFieldDataType.Text;
        Value = @"";
    }

    /// <summary>Code linking back to the field definition.</summary>
    public String FieldCode { get; set; }

    /// <summary>Display caption snapshot.</summary>
    public String Caption { get; set; }

    /// <summary>Data type of the value.</summary>
    public DMSFieldDataType DataType { get; set; }

    /// <summary>The captured value, serialised as text.</summary>
    public String Value { get; set; }
}
