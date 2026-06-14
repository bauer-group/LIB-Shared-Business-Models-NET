using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Supplier of a product. Extends <see cref="ERPProductManufacturer"/> and adds the active
    /// flag and supplier-specific price records.
    /// </summary>
    public class ERPProductSupplier : ERPProductManufacturer
    {
        /// <summary>Initialises a new supplier as active with neutral defaults.</summary>
        public ERPProductSupplier()
        {
            Active = true;

            Prices = new List<ERPProductPrices>(0);
        }

        /// <summary>Whether the supplier is currently active for the product.</summary>
        public Boolean Active { get; set; }

        /// <summary>Supplier-specific price records.</summary>
        public List<ERPProductPrices> Prices { get; set; }
    }
}
