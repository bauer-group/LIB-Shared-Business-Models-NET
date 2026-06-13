namespace BAUERGROUP.Shared.Business.Models;

/// <summary>
/// Abstract base for business types that do not require an entity identity or
/// change tracking. Implements the <see cref="IBusiness"/> marker interface.
/// </summary>
public abstract class Business : IBusiness
{
}
