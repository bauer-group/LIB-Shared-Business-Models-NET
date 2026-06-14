using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// An access role grouping a set of editor identities. Extends <see cref="ERPCodeName"/>
    /// (code + name) with the role's <see cref="Members"/>.
    /// </summary>
    public class ERPRole : ERPCodeName
    {
        /// <summary>Initialises a new instance with an empty member list.</summary>
        public ERPRole()
        {
            Members = new List<ERPEditor>(0);
        }

        /// <summary>Editors that belong to this role.</summary>
        public List<ERPEditor> Members { get; set; }
    }
}
