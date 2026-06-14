using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Classifies the role of a single <see cref="ERPDocumentLine"/> — a real product,
    /// an ancillary charge, or a non-product presentation line.
    /// </summary>
    public enum ERPDocumentLineType
    {
        /// <summary>References a product from the article master.</summary>
        ArticleMasterProduct = 0,

        Product = 1,
        /// <summary>Ancillary charge or accessory line.</summary>
        Ancillary = 2,
        /// <summary>Bill-of-materials line.</summary>
        BOM = 3,

        /// <summary>Free-text line carrying no quantity or price.</summary>
        Text = 100,
        /// <summary>Comment line carrying no quantity or price.</summary>
        Comment = 101,

        /// <summary>Subtotal line summing the preceding lines.</summary>
        Subtotal = 200
    }
}
