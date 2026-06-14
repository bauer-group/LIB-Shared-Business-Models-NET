using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// A single identification record for a content item — an identifier value tagged with its
    /// <see cref="ShippingContentsIdentificationType"/> (LOT, serial, IMEI, UUID, …).
    /// </summary>
    public class ShippingContentsIdentification
    {
        /// <summary>Initialises a new instance with neutral defaults.</summary>
        public ShippingContentsIdentification()
        {
            Value = null;
            MinimumDurabilityDate = null;
            Type = ShippingContentsIdentificationType.None;
        }

        /// <summary>The identifier value, interpreted according to <see cref="Type"/>.</summary>
        public String Value { get; set; }
        /// <summary>Minimum durability / best-before date when <see cref="Type"/> is <see cref="ShippingContentsIdentificationType.MinimumDurabilityDate"/>; otherwise <c>null</c>.</summary>
        public DateTime? MinimumDurabilityDate { get; set; }
        /// <summary>Kind of identifier carried in <see cref="Value"/>.</summary>
        public ShippingContentsIdentificationType Type { get; set; }
    }
}
