using System;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// A filing mask (Ablagemaske): a reusable template that ties a document type to its target filing
/// structure, folder, keywording mask, retention policy and default classification. Selecting a
/// filing mask pre-configures where a document lands and how it is indexed and retained.
/// </summary>
public class DMSFilingMask : DMSObjectBase
{
    /// <summary>Initialises a new filing mask with neutral defaults.</summary>
    public DMSFilingMask()
    {
        Name = Description = @"";
        DocumentTypeUID = Guid.Empty;
        TargetStructureUID = Guid.Empty;
        TargetFolderUID = Guid.Empty;
        IndexMaskUID = Guid.Empty;
        RetentionPolicyUID = Guid.Empty;
        DefaultClassification = DMSSecurityClassification.Internal;
        IsActive = true;
    }

    /// <summary>Mask name.</summary>
    public String Name { get; set; }

    /// <summary>Optional description.</summary>
    public String Description { get; set; }

    /// <summary>Document type the mask is for.</summary>
    public Guid DocumentTypeUID { get; set; }

    /// <summary>Virtual filing structure documents are placed into (<see cref="DMSFilingStructure"/>).</summary>
    public Guid TargetStructureUID { get; set; }

    /// <summary>Target physical folder (<see cref="DMSFolder"/>).</summary>
    public Guid TargetFolderUID { get; set; }

    /// <summary>Keywording mask applied during capture (<see cref="DMSIndexMask"/>).</summary>
    public Guid IndexMaskUID { get; set; }

    /// <summary>Retention policy assigned on filing (<see cref="DMSRetentionPolicy"/>).</summary>
    public Guid RetentionPolicyUID { get; set; }

    /// <summary>Default security classification applied on filing.</summary>
    public DMSSecurityClassification DefaultClassification { get; set; }

    /// <summary>Whether the mask is currently in use.</summary>
    public Boolean IsActive { get; set; }
}
