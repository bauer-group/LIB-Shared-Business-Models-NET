using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A load carrier (pallet / container). Extends <see cref="ERPCodeName"/>, so it is
    /// identified by a code and an optional name.
    /// </summary>
    public class ERPStockLoadingTool : ERPCodeName
    {
        /// <summary>Initialises a new load carrier with neutral defaults.</summary>
        public ERPStockLoadingTool()
        {

        }

        /// <summary>Initialises a new load carrier with the specified code.</summary>
        /// <param name="sCode">The carrier code.</param>
        public ERPStockLoadingTool(string sCode)
        {
            Code = sCode;
        }

        /// <summary>Initialises a new load carrier with the specified code and name.</summary>
        /// <param name="sCode">The carrier code.</param>
        /// <param name="sName">The carrier name.</param>
        public ERPStockLoadingTool(string sCode, string sName)
        {
            Code = sCode;
            Name = sName;
        }
    }
}
