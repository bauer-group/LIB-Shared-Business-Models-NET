using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// Defines a single index (keywording) field. Extends <see cref="ERPCodeName"/> (Code + Name) and
/// adds the data type, capture rules and optional picklist. Used by a keywording mask
/// (<see cref="DMSIndexMask"/>) to describe what metadata is captured for a document class.
/// </summary>
public class DMSIndexFieldDefinition : ERPCodeName
{
    /// <summary>Initialises a new field definition with neutral defaults.</summary>
    public DMSIndexFieldDefinition()
    {
        DataType = DMSFieldDataType.Text;
        IsRequired = false;
        IsKeyField = false;
        Order = 0;
        DefaultValue = ValidationPattern = @"";
        PicklistValues = new List<String>(0);
    }

    /// <summary>Data type that governs interpretation and input validation.</summary>
    public DMSFieldDataType DataType { get; set; }

    /// <summary>Whether a value is mandatory.</summary>
    public Boolean IsRequired { get; set; }

    /// <summary>Whether the field is a primary search/key field for the document class.</summary>
    public Boolean IsKeyField { get; set; }

    /// <summary>Display order within the mask.</summary>
    public Int32 Order { get; set; }

    /// <summary>Default value pre-filled in the capture form.</summary>
    public String DefaultValue { get; set; }

    /// <summary>Optional validation pattern (e.g. a regular expression).</summary>
    public String ValidationPattern { get; set; }

    /// <summary>Allowed values when <see cref="DataType"/> is <see cref="DMSFieldDataType.Picklist"/>.</summary>
    public List<String> PicklistValues { get; set; }
}
