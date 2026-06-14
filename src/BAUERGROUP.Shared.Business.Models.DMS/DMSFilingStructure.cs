using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// Defines a virtual path structure — an ordered set of levels that compute a virtual folder path
/// from a document's index fields (e.g. <c>/{Year}/{Customer}/{DocumentType}</c>). A document can
/// be filed into several such structures simultaneously (see <see cref="DMSFilingLocation"/>),
/// giving multiple independent navigational views over the same documents.
/// </summary>
public class DMSFilingStructure : DMSObjectBase
{
    /// <summary>Initialises a new structure with neutral defaults.</summary>
    public DMSFilingStructure()
    {
        Name = Description = @"";
        IsActive = true;
        Levels = new List<DMSFilingStructureLevel>(0);
    }

    /// <summary>Structure name.</summary>
    public String Name { get; set; }

    /// <summary>Optional description.</summary>
    public String Description { get; set; }

    /// <summary>Whether the structure is currently in use.</summary>
    public Boolean IsActive { get; set; }

    /// <summary>Ordered levels that compose the virtual path.</summary>
    public List<DMSFilingStructureLevel> Levels { get; set; }
}
