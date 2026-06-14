using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
	/// <summary>
    /// Extended product attributes covering handling and safety: hazard flags, allowed
    /// temperature range, safety instructions and substance code. Extends <see cref="ERPObjectBase"/>.
    /// </summary>
	public class ERPProductExtensions : ERPObjectBase
    {
        /// <summary>Initialises a new instance with neutral defaults (<see cref="ERPProductFlag.None"/>, zero temperatures, empty texts).</summary>
        public ERPProductExtensions()
        {
            Flags = ERPProductFlag.None;

            MinimumAllowedTemperature = 0m;
            MaximumAllowedTemperature = 0m;
            SafetyInstructions = @"";
            SubstanceCode = @"";
        }

        /// <summary>Handling/safety flags for the product (bit flags).</summary>
        public ERPProductFlag Flags { get; set; }

        /// <summary>Lowest temperature the product may be exposed to.</summary>
        public Decimal MinimumAllowedTemperature { get; set; }
        /// <summary>Highest temperature the product may be exposed to.</summary>
        public Decimal MaximumAllowedTemperature { get; set; }
        /// <summary>Free-text safety / handling instructions.</summary>
        public String SafetyInstructions { get; set; }
        /// <summary>Code identifying the regulated substance, if any.</summary>
        public String SubstanceCode { get; set; }
    }
}
