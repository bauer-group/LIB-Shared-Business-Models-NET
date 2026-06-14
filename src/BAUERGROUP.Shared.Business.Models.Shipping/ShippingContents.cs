using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class ShippingContents
    {
        public ShippingContents()
        {
            Reference = @"";
            Quantity = 0.0m;

            Identification = null;

            SubstanceCode = null;
            SubstanceLabeling = ShippingContentsLabeling.None;
            DangerousGoodsRegulationLevel = DangerousGoodsRegulationLevel.None;
    }

        public String Reference { get; set; }
        public Decimal Quantity { get; set; }

        public List<ShippingContentsIdentification> Identification { get; set; }

        public String SubstanceCode { get; set; } // UN-Number, Unique Ingredient Identifier (UNII), CAS Number, Administrative Controlled Substances Code Number (ACSCN), ECHA, ...
        public ShippingContentsLabeling SubstanceLabeling { get; set; }

        // Only meaningful when SubstanceLabeling has HazardousGoods set; otherwise expected to be None.
        public DangerousGoodsRegulationLevel DangerousGoodsRegulationLevel { get; set; }
    }
}
