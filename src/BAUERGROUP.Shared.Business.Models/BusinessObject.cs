using System;

namespace BAUERGROUP.Shared.Business.Models;

/// <summary>
/// Abstract base for business entities with a stable identity (<see cref="UID"/>)
/// and a change timestamp (<see cref="Changed"/>). Implements
/// <see cref="IBusinessObject"/>.
/// </summary>
/// <remarks>
/// <para>
/// By default <see cref="UID"/> is initialised with a freshly generated
/// <see cref="Guid.NewGuid"/>, and <see cref="Changed"/> is stamped with the
/// current UTC time. To re-hydrate a known entity, set <see cref="UID"/> via the
/// object initializer (it is <c>init</c>-only) or call the
/// <see cref="BusinessObject(Guid)"/> constructor — the persistence layer
/// supplies the identity when loading from storage.
/// </para>
/// <para>
/// <see cref="Changed"/> is mutable on purpose so callers can update it at the
/// moment of mutation. Persistence layers should update it before each save.
/// </para>
/// </remarks>
public abstract class BusinessObject : Business, IBusinessObject
{
    /// <summary>
    /// Initialises a new instance with an auto-generated <see cref="UID"/> and a
    /// <see cref="Changed"/> timestamp of the current UTC time.
    /// </summary>
    protected BusinessObject()
    {
    }

    /// <summary>
    /// Initialises a new instance with an explicit <see cref="UID"/> — typically
    /// when re-hydrating a known entity from storage. <see cref="Guid.Empty"/>
    /// falls back to the auto-generated identity.
    /// </summary>
    /// <param name="gUID">The stable identity to assign, or <see cref="Guid.Empty"/> to auto-generate.</param>
    protected BusinessObject(Guid gUID)
    {
        if (gUID != Guid.Empty)
        {
            UID = gUID;
        }
    }

    /// <inheritdoc />
    public Guid UID { get; init; } = Guid.NewGuid();

    /// <inheritdoc />
    public DateTime Changed { get; set; } = DateTime.UtcNow;
}
