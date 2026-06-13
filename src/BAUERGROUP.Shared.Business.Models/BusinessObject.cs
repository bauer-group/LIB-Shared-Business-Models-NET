namespace BAUERGROUP.Shared.Business.Models;

/// <summary>
/// Abstract base for business entities with a stable identity (<see cref="UID"/>)
/// and a change timestamp (<see cref="Changed"/>). Implements
/// <see cref="IBusinessObject"/>.
/// </summary>
/// <remarks>
/// <para>
/// On construction <see cref="UID"/> is initialised with a freshly generated
/// <see cref="Guid.NewGuid"/>, and <see cref="Changed"/> is stamped with the
/// current UTC time. Derived types should not override this construction-time
/// behaviour — the persistence layer is responsible for setting
/// <see cref="UID"/> via deserialiser-init when re-hydrating from storage.
/// </para>
/// <para>
/// <see cref="Changed"/> is mutable on purpose so callers can update it at the
/// moment of mutation. Persistence layers should update it before each save.
/// </para>
/// </remarks>
public abstract class BusinessObject : Business, IBusinessObject
{
    /// <inheritdoc />
    public Guid UID { get; init; } = Guid.NewGuid();

    /// <inheritdoc />
    public DateTime Changed { get; set; } = DateTime.UtcNow;
}
