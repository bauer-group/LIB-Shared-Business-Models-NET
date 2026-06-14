using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// An external partner's article number / reference for a product. Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPProductPartnersReference: ERPObjectBase
    {
        /// <summary>Initialises a new instance with an empty partner and reference.</summary>
        public ERPProductPartnersReference()
        {
            Partner = new ERPBusinessAssociate();
            Reference = @"";
        }

        /// <summary>The partner that owns the external reference.</summary>
        public ERPBusinessAssociate Partner { get; set; }
        /// <summary>The partner's article number / reference for the product.</summary>
        public String Reference { get; set; }
    }
}
