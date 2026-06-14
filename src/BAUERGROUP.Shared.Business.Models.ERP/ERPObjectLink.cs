using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A loose, typed cross-object reference pointing at another object by its UID.
    /// Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPObjectLink : ERPObjectBase
    {
        /// <summary>Initialises an unset link (<see cref="ERPObjectLinkType.None"/>, empty referral).</summary>
        public ERPObjectLink()
        {
            Type = ERPObjectLinkType.None;
            ReferralUID = Guid.Empty;
        }

        /// <summary>Relationship kind of the link.</summary>
        public ERPObjectLinkType Type { get; set; }
        /// <summary>UID of the referenced object (<see cref="Guid.Empty"/> if not set).</summary>
        public Guid ReferralUID { get; set; }
    }
}
