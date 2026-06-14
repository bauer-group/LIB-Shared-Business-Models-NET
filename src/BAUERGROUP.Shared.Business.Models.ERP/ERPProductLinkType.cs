using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPProductLinkType
    {
        Other = -1,

        Variant = 1,
        Accessories = 2,
        Replacement = 3,
        Similar = 4,

        BundleMainProduct = 20,
        BundleContentProduct = 21
    }
}
