using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProductLink : ERPObjectBase
    {
        public ERPProductLink()
        {
            Type = ERPProductLinkType.Variant;

            Product = new ERPProduct();
        }

        public ERPProductLinkType Type { get; set; }

        public ERPProduct Product { get; set; }
    }
}
