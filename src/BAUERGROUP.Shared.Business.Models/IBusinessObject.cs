using System;

namespace BAUERGROUP.Shared.Business.Models;

/// <summary>
/// Contract for a business entity with a stable identity and a change timestamp.
/// </summary>
/// <remarks>
/// <para>
/// Every entity that participates in change-tracking events
/// (<c>BusinessObjectChanged</c>) and DB-backed persistence implements this
/// interface.
/// </para>
/// <para>
/// <see cref="UID"/> uniquely identifies the entity instance and is intentionally
/// init-only: it is set during construction or by a deserializer, never mutated
/// afterwards. <see cref="Changed"/> is settable so callers and persistence
/// layers can stamp the entity at the moment of mutation.
/// </para>
/// </remarks>
public interface IBusinessObject : IBusiness
{
    /// <summary>
    /// Gets the unique identifier of this entity instance.
    /// </summary>
    Guid UID { get; init; }

    /// <summary>
    /// Gets or sets the UTC timestamp of the last mutation to this entity's state.
    /// </summary>
    DateTime Changed { get; set; }
}
