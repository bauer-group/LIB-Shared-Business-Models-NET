using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Bitwise handling / regulatory flags of a product.
    /// </summary>
    [Flags]
    public enum ERPProductFlag
    {
        /// <summary>No flags set.</summary>
        None = 0,

        HazardousGoods = 2,
        Anesthetic = 4,
        TemperatureControlled = 8
    }
}
