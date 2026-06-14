using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Packaging used for a parcel — its identifying code, name, dimensions and tare weight.
    /// </summary>
    public class ParcelPackaging
    {
        /// <summary>Initialises a new instance with neutral defaults.</summary>
        public ParcelPackaging()
        {
            Code = Name = @"";

            Dimensions = null;
            Weight = 0m;
        }

        /// <summary>Packaging type code.</summary>
        public String Code { get; set; }
        /// <summary>Human-readable packaging name.</summary>
        public String Name { get; set; }

        /// <summary>Physical dimensions of the packaging (<c>null</c> if not specified).</summary>
        public ParcelDimensions Dimensions { get; set; }

        /// <summary>Tare weight of the packaging.</summary>
        public Decimal Weight { get; set; }
    }
}
