using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
	public class ERPProductExtensions : ERPObjectBase
    {
        public ERPProductExtensions()
        {
            Flags = ERPProductFlag.None;

            MinimumAllowedTemperature = 0m;
            MaximumAllowedTemperature = 0m;
            SafetyInstructions = @"";
            SubstanceCode = @"";
        }

        public ERPProductFlag Flags { get; set; }

        public Decimal MinimumAllowedTemperature { get; set; }
        public Decimal MaximumAllowedTemperature { get; set; }
        public String SafetyInstructions { get; set; }
        public String SubstanceCode { get; set; }
    }
}
