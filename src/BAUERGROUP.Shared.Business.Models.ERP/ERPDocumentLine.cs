using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A single line item of an <see cref="ERPDocument"/>. Extends <see cref="ERPProduct"/>
    /// with line-specific data: quantity breakdown, pricing, delivery status/type and
    /// per-line shipping details.
    /// </summary>
    public class ERPDocumentLine : ERPProduct
    {
        /// <summary>Initialises a new product line with neutral defaults and zero amounts.</summary>
        public ERPDocumentLine()
        {            
            Type = ERPDocumentLineType.Product;
            ShippingDate = null;
            ShippingAddress = null;

            Quantities = new ERPDocumentLineQuantities();
            
            Comment = @"";

            Identification = new List<ERPProductLOTSerial>(0);

            UnitPrice = 0m;
            Rebate = 0m;
            Discountable = true;

            ExternalReference = @"";

            SKU = @"";

            ExternalPosition = @"";

            DeliveryMethod = ERPDocumentLineDeliveryType.Unknown;
            DeliveryStatus = ERPDocumentLineDeliveryStatus.Unknown;
        }
                
        /// <summary>Role of this line (product, ancillary, text, subtotal, …).</summary>
        public ERPDocumentLineType Type { get; set; }
        /// <summary>Line-specific shipping date overriding the document date (<c>null</c> if not set).</summary>
        public DateTime? ShippingDate { get; set; }
        /// <summary>Line-specific shipping address overriding the document address (<c>null</c> if not set).</summary>
        public ERPBusinessAssociate ShippingAddress { get; set; }

        /// <summary>Quantity breakdown for this line across its fulfilment stages.</summary>
        public ERPDocumentLineQuantities Quantities { get; set; }
        
        /// <summary>Computed net line total: billed quantity × <see cref="UnitPrice"/> less <see cref="Rebate"/> percent.</summary>
        public Decimal TotalPrice { get { return Quantities.QuantityBilled * UnitPrice * ((100 - Rebate) / 100); } }
        
        /// <summary>Free-text comment on the line.</summary>
        public String Comment { get; set; }

        /// <summary>LOT / serial-number identifications for the delivered quantity.</summary>
        public List<ERPProductLOTSerial> Identification { get; set; }

        /// <summary>Unit price in the document's currency, before line rebate.</summary>
        public Decimal UnitPrice { get; set; }
        /// <summary>Line rebate as a percentage applied to <see cref="UnitPrice"/>.</summary>
        public Decimal Rebate { get; set; }
        /// <summary>Whether a document-level discount may be applied to this line.</summary>
        public bool Discountable { get; set; }

        /// <summary>External system reference for this line. Free-text.</summary>
        public String ExternalReference { get; set; }

        /// <summary>Stock-keeping unit identifier.</summary>
        public String SKU { get; set; }

        /// <summary>Line position number in the external system. Free-text.</summary>
        public String ExternalPosition { get; set; }

        /// <summary>How this line is delivered (physical, electronic, …).</summary>
        public ERPDocumentLineDeliveryType DeliveryMethod { get; set; }
        /// <summary>Current fulfilment status of this line.</summary>
        public ERPDocumentLineDeliveryStatus DeliveryStatus { get; set; }
    }
}
