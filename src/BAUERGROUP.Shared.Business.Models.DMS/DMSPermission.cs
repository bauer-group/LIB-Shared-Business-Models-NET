using System;

namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>
/// Permissions granted (or denied) to a principal on a document, combinable as flags.
/// <see cref="FullControl"/> is the union of all individual rights.
/// </summary>
[Flags]
public enum DMSPermission
{
    /// <summary>No permissions.</summary>
    None = 0,
    Read = 1,
    Write = 2,
    Delete = 4,
    Share = 8,
    ChangePermissions = 16,
    Print = 32,
    Download = 64,
    Sign = 128,
    Annotate = 256,
    /// <summary>All individual rights combined.</summary>
    FullControl = Read | Write | Delete | Share | ChangePermissions | Print | Download | Sign | Annotate
}
