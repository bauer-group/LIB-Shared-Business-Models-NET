namespace BAUERGROUP.Shared.Business.Models.DMS;

/// <summary>Kind of security principal an access-control entry applies to.</summary>
public enum DMSPrincipalType
{
    /// <summary>Not set.</summary>
    Unspecified = 0,
    User = 1,
    Group = 2,
    Role = 3,
    /// <summary>The "everyone" / authenticated-users pseudo-principal.</summary>
    Everyone = 4
}
