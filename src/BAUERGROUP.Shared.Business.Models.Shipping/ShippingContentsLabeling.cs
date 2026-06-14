using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Hazard and handling labels that apply to the goods inside a parcel. Combinable flags.
    /// </summary>
    [Flags]
    public enum ShippingContentsLabeling
    {
        /// <summary>No special labelling.</summary>
        None = 0,

        /// <summary>Dangerous goods; drives the <see cref="DangerousGoodsRegulationLevel"/> declaration.</summary>
        HazardousGoods = 2,
        /// <summary>Anaesthetic / controlled medical substance.</summary>
        Anesthetic = 4,
        /// <summary>Requires temperature-controlled handling.</summary>
        TemperatureControlled = 8
    }
}
