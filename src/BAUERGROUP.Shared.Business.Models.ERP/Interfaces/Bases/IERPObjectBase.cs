using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Bases.Interfaces.Bases
{
    /// <summary>
    /// Contract for ERP domain entities. Extends <see cref="IBusinessObject"/> and
    /// <see cref="IBusiness"/> with the tenant/client association (<see cref="ClientUID"/>).
    /// </summary>
    public interface IERPObjectBase : IBusinessObject, IBusiness
    {
        /// <summary>Identifier of the owning tenant/client (<see cref="Guid.Empty"/> if not set).</summary>
        Guid ClientUID { get; set; }
    }
}