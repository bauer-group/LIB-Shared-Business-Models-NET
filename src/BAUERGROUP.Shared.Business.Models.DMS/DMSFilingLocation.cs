using System;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// Places a document into a virtual path within a filing structure. Because a document can hold
/// several filing locations, the same document appears under multiple virtual paths without
/// duplicating its content (multi-filing).
/// </summary>
public class DMSFilingLocation : DMSObjectBase
{
    /// <summary>Initialises a new filing location with neutral defaults.</summary>
    public DMSFilingLocation()
    {
        DocumentUID = Guid.Empty;
        StructureUID = Guid.Empty;
        FolderUID = Guid.Empty;
        VirtualPath = @"";
        IsPrimary = false;
    }

    /// <summary>The filed document.</summary>
    public Guid DocumentUID { get; set; }

    /// <summary>The structure that produced the virtual path (<see cref="Guid.Empty"/> for a manual placement).</summary>
    public Guid StructureUID { get; set; }

    /// <summary>The resolved leaf folder, if the structure maps onto physical folders.</summary>
    public Guid FolderUID { get; set; }

    /// <summary>The resolved virtual path, e.g. <c>/2026/ACME/Invoices</c>.</summary>
    public String VirtualPath { get; set; }

    /// <summary>Whether this is the document's primary filing location.</summary>
    public Boolean IsPrimary { get; set; }
}
