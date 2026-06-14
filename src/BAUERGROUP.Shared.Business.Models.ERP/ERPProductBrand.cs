using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A product brand. Extends <see cref="ERPProductText"/> so it carries the localized
    /// name / description / notice surface of a brand.
    /// </summary>
    public class ERPProductBrand : ERPProductText
    {
        /// <summary>Initialises a new brand with neutral defaults.</summary>
        public ERPProductBrand()
        {

        }
    }
}
