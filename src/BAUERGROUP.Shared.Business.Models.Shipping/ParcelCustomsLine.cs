using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// A single line item in a customs declaration, describing one type of goods in the parcel.
    /// </summary>
    public class ParcelCustomsLine
    {
        /// <summary>Initialises a new instance with neutral defaults.</summary>
        public ParcelCustomsLine()
        {
            SSCC = null;

            Reference = null;

            TariffNumber = @"";
            Description = @"";

            CountryOfOrigin = null;

            Quantity = 0m;
            Value = 0m;
            Weight = 0m;
        }

        /// <summary>SSCC of the parcel this line belongs to (<c>null</c> if not set).</summary>
        public String SSCC { get; set; }

        /// <summary>Free-text reference for the line item (<c>null</c> if not set).</summary>
        public String Reference { get; set; }

        /// <summary>Customs tariff (HS) number of the goods.</summary>
        public String TariffNumber { get; set; }
        /// <summary>Goods description.</summary>
        public String Description { get; set; }

        /// <summary>Country of origin of the goods (<c>null</c> if not set).</summary>
        public String CountryOfOrigin { get; set; }

        /// <summary>Number of units covered by this line.</summary>
        public Decimal Quantity { get; set; }
        /// <summary>Declared value of this line, in the declaration's currency.</summary>
        public Decimal Value { get; set; }
        /// <summary>Weight of the goods in this line.</summary>
        public Decimal Weight { get; set; }
    }
}