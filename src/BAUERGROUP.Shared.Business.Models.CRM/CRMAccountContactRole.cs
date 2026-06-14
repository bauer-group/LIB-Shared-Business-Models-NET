using System;
using BAUERGROUP.Shared.Business.Models.CRM.Bases;

namespace BAUERGROUP.Shared.Business.Models.CRM;

/// <summary>
/// Associates a <see cref="CRMContact"/> with a <see cref="CRMAccount"/> in a specific role
/// (decision maker, technical contact …). Models the many-to-many contact↔account relationship,
/// since a person can act for several accounts and an account has several relevant contacts.
/// </summary>
public class CRMAccountContactRole : CRMObjectBase
{
    /// <summary>Initialises a new relationship with neutral defaults.</summary>
    public CRMAccountContactRole()
    {
        AccountUID = Guid.Empty;
        ContactUID = Guid.Empty;
        Role = CRMContactRole.Unspecified;
        IsPrimary = false;
    }

    /// <summary>The account side of the relationship.</summary>
    public Guid AccountUID { get; set; }

    /// <summary>The contact side of the relationship.</summary>
    public Guid ContactUID { get; set; }

    /// <summary>Role the contact plays for this account.</summary>
    public CRMContactRole Role { get; set; }

    /// <summary>Whether this role is the primary one for the pairing.</summary>
    public Boolean IsPrimary { get; set; }
}
