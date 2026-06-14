using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
	/// <summary>
	/// A key/value specification attribute of a product. Extends <see cref="ERPCodeName"/>
	/// (code + name) and adds the attribute value.
	/// </summary>
	public class ERPProductAttribute : ERPCodeName
	{
        /// <summary>Initialises a new attribute with empty code and value.</summary>
        public ERPProductAttribute()
            : this(@"", @"")
        {

        }

        /// <summary>Initialises a new attribute with the given code and value.</summary>
        /// <param name="sCode">Attribute code.</param>
        /// <param name="sValue">Attribute value.</param>
        public ERPProductAttribute(String sCode, String sValue)
            : this(sCode, @"", sValue)
        {

        }

        /// <summary>Initialises a new attribute with the given code, name and value.</summary>
        /// <param name="sCode">Attribute code.</param>
        /// <param name="sName">Display name of the attribute.</param>
        /// <param name="sValue">Attribute value.</param>
        public ERPProductAttribute(String sCode, String sName, String sValue)
		{
            Code = sCode;
            Name = sName;
			Value = sValue;
		}

		/// <summary>Value of the attribute.</summary>
		public string Value { get; set; }
	}
}
