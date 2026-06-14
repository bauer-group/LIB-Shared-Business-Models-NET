using BAUERGROUP.Shared.Core.Images;
using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class ShippingImage
    {
        public ShippingImage()
        {
            Timestamp = DateTime.UtcNow;
            Picture = null;
        }

        public IndependentImage Picture { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
