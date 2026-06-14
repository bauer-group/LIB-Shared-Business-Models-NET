using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.CRM.Bases;

/// <summary>
/// Common base for CRM domain entities. Inherits the stable <c>UID</c> identity,
/// the <c>Changed</c> UTC timestamp and the <c>ClientUID</c> tenant association from
/// <see cref="ERPObjectBase"/> — CRM is a subsidiary system of the ERP model and
/// shares its object foundation rather than redefining it.
/// </summary>
public abstract class CRMObjectBase : ERPObjectBase
{
    /// <summary>Initialises a new instance with an auto-generated identity.</summary>
    protected CRMObjectBase()
        : base()
    {
    }

    /// <summary>
    /// Initialises a new instance with an explicit identity — typically when
    /// re-hydrating a known entity from storage.
    /// </summary>
    /// <param name="gUID">The stable identity to assign, or <see cref="Guid.Empty"/> to auto-generate.</param>
    protected CRMObjectBase(Guid gUID)
        : base(gUID)
    {
    }
}
