using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
	public class ERPProductAttribute : ERPCodeName
	{
        public ERPProductAttribute()
            : this(@"", @"")
        {

        }

        public ERPProductAttribute(String sCode, String sValue)
            : this(sCode, @"", sValue)
        {

        }
        
        public ERPProductAttribute(String sCode, String sName, String sValue)
		{
            Code = sCode;
            Name = sName;
			Value = sValue;
		}

		public string Value { get; set; }
	}
}
