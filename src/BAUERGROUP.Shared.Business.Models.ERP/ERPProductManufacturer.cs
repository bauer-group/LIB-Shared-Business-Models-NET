using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Manufacturer of a product. Extends <see cref="ERPBusinessAssociate"/>, so it carries the
    /// full party surface, and adds the brands it produces.
    /// </summary>
    public class ERPProductManufacturer : ERPBusinessAssociate
    {
        /// <summary>Initialises a new manufacturer with neutral defaults.</summary>
        public ERPProductManufacturer()
        {
            Brands = new List<ERPProductBrand>(0);
        }

        /// <summary>Brands produced by the manufacturer.</summary>
        public List<ERPProductBrand> Brands { get; set; }
    }
}
