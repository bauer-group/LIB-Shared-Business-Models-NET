using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A warehouse / site. Extends <see cref="ERPCodeName"/>, so it carries a code and name,
    /// and adds the location type.
    /// </summary>
    public class ERPStockLocation : ERPCodeName
    {
        /// <summary>Initialises a new stock location with neutral defaults.</summary>
        public ERPStockLocation()
        {
            Type = null;
        }

        /// <summary>Classification of the location.</summary>
        public ERPStockType Type { get; set; }
    }
}
