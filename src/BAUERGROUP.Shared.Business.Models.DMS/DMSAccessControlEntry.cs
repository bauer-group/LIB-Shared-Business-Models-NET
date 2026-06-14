using System;
using BAUERGROUP.Shared.Business.Models.DMS.Bases;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// One access-control entry (ACE) on a document: the permissions a principal is granted or denied.
/// <see cref="IsDeny"/> marks an explicit deny (which conventionally overrides allows), and
/// <see cref="IsInherited"/> distinguishes inherited entries from ones set directly on the document.
/// </summary>
public class DMSAccessControlEntry : DMSObjectBase
{
    /// <summary>Initialises a new ACE granting <see cref="DMSPermission.Read"/> to a user.</summary>
    public DMSAccessControlEntry()
    {
        PrincipalUID = Guid.Empty;
        PrincipalType = DMSPrincipalType.User;
        PrincipalName = @"";
        Permissions = DMSPermission.Read;
        IsDeny = false;
        IsInherited = false;
    }

    /// <summary>The principal the entry applies to.</summary>
    public Guid PrincipalUID { get; set; }

    /// <summary>Whether the principal is a user, group, role or "everyone".</summary>
    public DMSPrincipalType PrincipalType { get; set; }

    /// <summary>Principal display name snapshot.</summary>
    public String PrincipalName { get; set; }

    /// <summary>The permission set granted or denied.</summary>
    public DMSPermission Permissions { get; set; }

    /// <summary>True for an explicit deny entry; false for a grant.</summary>
    public Boolean IsDeny { get; set; }

    /// <summary>True when the entry was inherited from a parent folder rather than set directly.</summary>
    public Boolean IsInherited { get; set; }
}
