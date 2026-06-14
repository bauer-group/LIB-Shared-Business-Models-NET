using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A unit of measure for a product (with conversion), identified by code and name.
    /// Extends <see cref="ERPCodeName"/>.
    /// </summary>
    public class ERPProductUnit : ERPCodeName
    {
        /// <summary>Initialises a new instance with empty code and name.</summary>
        public ERPProductUnit()
        {

        }
    }
}
