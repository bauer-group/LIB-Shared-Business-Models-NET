using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Describes the goods inside a parcel — quantity, per-item identification (EAN/serial/LOT, …),
    /// substance coding and the hazard/handling labels that drive dangerous-goods declaration.
    /// </summary>
    public class ShippingContents
    {
        /// <summary>Initialises a new instance with neutral defaults and no hazard labelling.</summary>
        public ShippingContents()
        {
            Reference = @"";
            Quantity = 0.0m;

            Identification = null;

            SubstanceCode = null;
            SubstanceLabeling = ShippingContentsLabeling.None;
            DangerousGoodsRegulationLevel = DangerousGoodsRegulationLevel.None;
    }

        /// <summary>Free-text reference identifying the content line (e.g. article number or description).</summary>
        public String Reference { get; set; }
        /// <summary>Quantity of the goods this content line represents.</summary>
        public Decimal Quantity { get; set; }

        /// <summary>Per-item identification records (EAN, serial, LOT, IMEI, …); <c>null</c> if none.</summary>
        public List<ShippingContentsIdentification> Identification { get; set; }

        /// <summary>Regulatory substance code: UN-Number, UNII, CAS Number, ACSCN, ECHA, … (<c>null</c> if not a controlled substance).</summary>
        public String SubstanceCode { get; set; } // UN-Number, Unique Ingredient Identifier (UNII), CAS Number, Administrative Controlled Substances Code Number (ACSCN), ECHA, ...
        /// <summary>Hazard/handling labels that apply to the substance (flags).</summary>
        public ShippingContentsLabeling SubstanceLabeling { get; set; }

        /// <summary>
        /// Dangerous-goods regulation level for the substance. Only meaningful when
        /// <see cref="SubstanceLabeling"/> has <see cref="ShippingContentsLabeling.HazardousGoods"/> set;
        /// otherwise expected to be <see cref="DangerousGoodsRegulationLevel.None"/>.
        /// </summary>
        public DangerousGoodsRegulationLevel DangerousGoodsRegulationLevel { get; set; }
    }
}
