using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// A free keyword / tag attached to a document. Extends <see cref="ERPCodeName"/> (Code + Name) and
/// adds an optional grouping category, so tags can be organised into facets.
/// </summary>
public class DMSTag : ERPCodeName
{
    /// <summary>Initialises a new tag with neutral defaults.</summary>
    public DMSTag()
    {
        Category = @"";
    }

    /// <summary>Optional facet / category the tag belongs to.</summary>
    public String Category { get; set; }
}
