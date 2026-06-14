using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class ShippingContentsIdentification
    {
        public ShippingContentsIdentification()
        {
            Value = null;
            MinimumDurabilityDate = null;
            Type = ShippingContentsIdentificationType.None;
        }

        public String Value { get; set; }
        public DateTime? MinimumDurabilityDate { get; set; }
        public ShippingContentsIdentificationType Type { get; set; }
    }
}
