using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPDocumentLine : ERPProduct
    {
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
                
        public ERPDocumentLineType Type { get; set; }
        public DateTime? ShippingDate { get; set; }
        public ERPBusinessAssociate ShippingAddress { get; set; }

        public ERPDocumentLineQuantities Quantities { get; set; }
        
        public Decimal TotalPrice { get { return Quantities.QuantityBilled * UnitPrice * ((100 - Rebate) / 100); } }
        
        public String Comment { get; set; }

        public List<ERPProductLOTSerial> Identification { get; set; }

        public Decimal UnitPrice { get; set; }
        public Decimal Rebate { get; set; }
        public bool Discountable { get; set; }

        public String ExternalReference { get; set; }

        public String SKU { get; set; }

        public String ExternalPosition { get; set; }

        public ERPDocumentLineDeliveryType DeliveryMethod { get; set; }
        public ERPDocumentLineDeliveryStatus DeliveryStatus { get; set; }
    }
}
