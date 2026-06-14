using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    [Flags]
    public enum ShippingContentsLabeling
    {
        None = 0,

        HazardousGoods = 2,
        Anesthetic = 4,
        TemperatureControlled = 8
    }
}
