using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases.Interfaces.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP.Bases
{
    /// <summary>
    /// Common base for ERP domain entities. Extends <see cref="BusinessObject"/> with the
    /// tenant/client association (<see cref="ClientUID"/>) that scopes every ERP object to a
    /// specific client.
    /// </summary>
    public class ERPObjectBase : BusinessObject, IERPObjectBase, IBusinessObject, IBusiness
    {
        /// <summary>Initialises a new instance with a new identity and an unset client (<see cref="Guid.Empty"/>).</summary>
        public ERPObjectBase()
            : base()
        {
            ClientUID = Guid.Empty;
        }

        /// <summary>Initialises a new instance with the specified identity and an unset client (<see cref="Guid.Empty"/>).</summary>
        /// <param name="gUID">The unique identifier to assign to this object.</param>
        public ERPObjectBase(Guid gUID)
            : base(gUID)
        {
            ClientUID = Guid.Empty;
        }

        /// <summary>Identifier of the owning tenant/client (<see cref="Guid.Empty"/> if not set).</summary>
        public Guid ClientUID { get; set; }
    }
}
