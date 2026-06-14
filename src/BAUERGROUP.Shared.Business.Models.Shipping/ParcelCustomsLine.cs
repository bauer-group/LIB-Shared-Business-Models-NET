using System;
using System.Collections.Generic;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class ParcelCustomsLine
    {
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

        public String SSCC { get; set; }

        public String Reference { get; set; }

        public String TariffNumber { get; set; }
        public String Description { get; set; }

        public String CountryOfOrigin { get; set; }

        public Decimal Quantity { get; set; }
        public Decimal Value { get; set; }
        public Decimal Weight { get; set; }
    }
}