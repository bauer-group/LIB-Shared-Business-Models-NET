using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A typed relationship from one product to another <see cref="ERPProduct"/>
    /// (accessory, replacement, variant, bundle member, …). Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPProductLink : ERPObjectBase
    {
        /// <summary>Initialises a new instance defaulting to a <see cref="ERPProductLinkType.Variant"/> link with an empty target product.</summary>
        public ERPProductLink()
        {
            Type = ERPProductLinkType.Variant;

            Product = new ERPProduct();
        }

        /// <summary>Kind of relationship this link represents.</summary>
        public ERPProductLinkType Type { get; set; }

        /// <summary>The related (target) product.</summary>
        public ERPProduct Product { get; set; }
    }
}
