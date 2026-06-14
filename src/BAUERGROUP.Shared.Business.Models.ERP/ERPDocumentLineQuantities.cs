using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPDocumentLineQuantities : ERPObjectBase
    {
        public ERPDocumentLineQuantities()
        {
            QuantityOrdered = 0m;
            QuantityAllocated = 0m;
            QuantityShipped = 0m;
            QuantityBilled = 0m;
            QuantityCanceled = 0m;
            QuantityRefunded = 0m;
        }

        public Decimal QuantityOrdered { get; set; }
        public Decimal QuantityAllocated { get; set; }
        public Decimal QuantityShipped { get; set; }
        public Decimal QuantityBilled { get; set; }
        public Decimal QuantityCanceled { get; set; }
        public Decimal QuantityRefunded { get; set; }

        public Decimal Quantity
        {
            set
            {
                QuantityOrdered = value;
                QuantityAllocated = value;
                QuantityShipped = value;
                QuantityBilled = value;
            }
        }

        [Obsolete]
        public Decimal QuantitiyOrdered { get { return QuantityOrdered; } set { QuantityOrdered = value; } }
        [Obsolete]
        public Decimal QuantitiyAllocated { get { return QuantityAllocated; } set { QuantityAllocated = value; } }
        [Obsolete]
        public Decimal QuantitiyDelivered { get { return QuantityDelivered; } set { QuantityDelivered = value; } }
        [Obsolete]
        public Decimal QuantitiyBilled { get { return QuantityBilled; } set { QuantityBilled = value; } }

        [Obsolete]
        public Decimal QuantityDelivered { get { return QuantityShipped; } set { QuantityShipped = value; } }
    }
}
