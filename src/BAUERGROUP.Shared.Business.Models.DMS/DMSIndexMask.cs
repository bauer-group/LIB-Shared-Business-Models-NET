using System;
using System.Collections.Generic;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// A keywording mask (Verschlagwortungsmaske): the ordered set of index-field definitions that
/// describe what metadata is captured for a given document type. Drives the capture form a user
/// fills in when filing a document.
/// </summary>
public class DMSIndexMask : DMSObjectBase
{
    /// <summary>Initialises a new mask with neutral defaults.</summary>
    public DMSIndexMask()
    {
        Name = Description = @"";
        DocumentTypeUID = Guid.Empty;
        IsActive = true;
        Fields = new List<DMSIndexFieldDefinition>(0);
    }

    /// <summary>Mask name.</summary>
    public String Name { get; set; }

    /// <summary>Optional description.</summary>
    public String Description { get; set; }

    /// <summary>Document type this mask applies to.</summary>
    public Guid DocumentTypeUID { get; set; }

    /// <summary>Whether the mask is currently in use.</summary>
    public Boolean IsActive { get; set; }

    /// <summary>Ordered field definitions captured by this mask.</summary>
    public List<DMSIndexFieldDefinition> Fields { get; set; }
}
