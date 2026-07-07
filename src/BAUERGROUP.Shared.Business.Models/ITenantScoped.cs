using System;

namespace BAUERGROUP.Shared.Business.Models;

/// <summary>
/// Opt-in contract for entities that participate in tenant isolation
/// (multi-tenancy / Row-Level Security).
/// </summary>
/// <remarks>
/// <para>
/// A <see cref="TenantUID"/> of <see langword="null"/> means the entity is
/// <b>not</b> tenant-scoped: tenant isolation is <i>inert</i> for it (this is the
/// default and preserves single-tenant behaviour). A non-<see langword="null"/>
/// value binds the entity to exactly one tenant, which the persistence layer
/// enforces on every read and write.
/// </para>
/// <para>
/// The contract is honoured uniformly by both storage backends: PostgreSQL
/// enforces it natively at the database via Row-Level Security policies, while
/// MongoDB enforces the same semantics at the application layer (a shared filter
/// that scopes queries and stamps writes). The current tenant is supplied
/// ambiently by the hosting layer, never by the caller.
/// </para>
/// <para>
/// <see cref="TenantUID"/> is deliberately distinct from the ERP
/// <c>ClientUID</c>: the latter is a business-client association on ERP objects,
/// whereas <see cref="TenantUID"/> is the infrastructure isolation boundary that
/// applies to any business object. The two may coincide in a deployment but are
/// modelled independently and must not be conflated.
/// </para>
/// </remarks>
public interface ITenantScoped
{
    /// <summary>
    /// Gets or sets the owning tenant identifier, or <see langword="null"/> when
    /// the entity is not tenant-scoped (isolation inert).
    /// </summary>
    Guid? TenantUID { get; set; }
}
