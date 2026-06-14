using System;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// A node in the physical/logical filing tree. Self-references its parent to form a hierarchy; the
/// materialised <see cref="Path"/> caches the position for fast display.
/// </summary>
public class DMSFolder : DMSObjectBase
{
    /// <summary>Initialises a new folder with neutral defaults.</summary>
    public DMSFolder()
    {
        Name = Description = Path = @"";
        ParentFolderUID = Guid.Empty;
        FolderType = DMSFolderType.Folder;
        Order = 0;
    }

    /// <summary>Folder display name.</summary>
    public String Name { get; set; }

    /// <summary>Parent folder (<see cref="Guid.Empty"/> for a root node).</summary>
    public Guid ParentFolderUID { get; set; }

    /// <summary>Materialised path from the root, e.g. <c>/Contracts/2026</c>.</summary>
    public String Path { get; set; }

    /// <summary>Kind of node.</summary>
    public DMSFolderType FolderType { get; set; }

    /// <summary>Sort order among siblings.</summary>
    public Int32 Order { get; set; }

    /// <summary>Optional description.</summary>
    public String Description { get; set; }
}
