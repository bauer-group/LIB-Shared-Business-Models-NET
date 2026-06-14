using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A sales channel (shop, marketplace, …) through which products are sold. Extends
    /// <see cref="ERPCodeName"/>, contributing the code/name pair, and adds a free-text reference
    /// plus custom fields.
    /// </summary>
    public class ERPSalesChannel : ERPCodeName
    {
        /// <summary>Initialises a new instance with empty code, name and reference.</summary>
        public ERPSalesChannel() :
            this(String.Empty, String.Empty, String.Empty)
        {

        }

        /// <summary>Initialises a new instance with the given code.</summary>
        /// <param name="sCode">Channel code.</param>
        public ERPSalesChannel(String sCode) :
            this(sCode, String.Empty, String.Empty)
        {

        }

        /// <summary>Initialises a new instance with the given code and name.</summary>
        /// <param name="sCode">Channel code.</param>
        /// <param name="sName">Display name.</param>
        public ERPSalesChannel(String sCode, String sName) :
            this(sCode, sName, String.Empty)
        {

        }

        /// <summary>Initialises a new instance with the given code, name and reference.</summary>
        /// <param name="sCode">Channel code.</param>
        /// <param name="sName">Display name.</param>
        /// <param name="sReference">Free-text reference.</param>
        public ERPSalesChannel(String sCode, String sName, String sReference) :
            base(sCode, sName)
        {
            Reference = sReference;
            CustomFields = new List<ERPCustomField>(0);
        }

        /// <summary>Free-text reference (e.g. external channel identifier).</summary>
        public String Reference { get; set; }

        /// <summary>Channel-specific custom field values.</summary>
        public List<ERPCustomField> CustomFields { get; set; }
    }
}
