using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A single batch/LOT or serial-number tracking entry for a product. Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPProductLOTSerial : ERPObjectBase
    {
        /// <summary>Initialises a new instance with an empty code, no durability date and type <see cref="ERPProductLOTSerialType.LOT"/>.</summary>
        public ERPProductLOTSerial() :
            this(@"", null, ERPProductLOTSerialType.LOT)
        {

        }

        /// <summary>Initialises a new instance with the specified code and type, and no durability date.</summary>
        /// <param name="sCode">The LOT or serial identifier.</param>
        /// <param name="eType">The kind of tracking identifier.</param>
        public ERPProductLOTSerial(string sCode, ERPProductLOTSerialType eType = ERPProductLOTSerialType.LOT) :
            this(sCode, null, eType)
        {

        }

        /// <summary>Initialises a new instance with the specified code, minimum durability date and type.</summary>
        /// <param name="sCode">The LOT or serial identifier.</param>
        /// <param name="dtMinimumDurability">Best-before / minimum durability date, or <c>null</c> if not applicable.</param>
        /// <param name="eType">The kind of tracking identifier.</param>
        public ERPProductLOTSerial(string sCode, DateTime? dtMinimumDurability, ERPProductLOTSerialType eType = ERPProductLOTSerialType.LOT)
        {
            Code = sCode;
            MinimumDurabilityDate = dtMinimumDurability;
            Type = eType;
        }

        /// <summary>The LOT or serial-number identifier.</summary>
        public string Code { get; set; }
        /// <summary>Best-before / minimum durability date (<c>null</c> if not applicable).</summary>
        public DateTime? MinimumDurabilityDate { get; set; }

        /// <summary>Kind of tracking identifier carried in <see cref="Code"/>.</summary>
        public ERPProductLOTSerialType Type { get; set; }
    }
}
