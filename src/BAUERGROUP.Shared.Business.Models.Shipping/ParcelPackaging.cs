using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class ParcelPackaging
    {
        public ParcelPackaging()
        {
            Code = Name = @"";

            Dimensions = null;
            Weight = 0m;
        }

        public String Code { get; set; }
        public String Name { get; set; }

        public ParcelDimensions Dimensions { get; set; }

        public Decimal Weight { get; set; }
    }
}
