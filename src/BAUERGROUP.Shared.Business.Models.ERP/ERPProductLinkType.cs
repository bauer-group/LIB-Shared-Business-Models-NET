using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Kind of relationship expressed by an <see cref="ERPProductLink"/> between two products.
    /// </summary>
    public enum ERPProductLinkType
    {
        /// <summary>A relationship that does not fit the predefined kinds.</summary>
        Other = -1,

        Variant = 1,
        Accessories = 2,
        Replacement = 3,
        Similar = 4,

        /// <summary>The product that represents the bundle as a whole.</summary>
        BundleMainProduct = 20,
        /// <summary>A product contained within a bundle.</summary>
        BundleContentProduct = 21
    }
}
