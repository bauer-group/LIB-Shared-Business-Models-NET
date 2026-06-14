using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Quantity breakdown of an <see cref="ERPDocumentLine"/> across its fulfilment stages
    /// (ordered, allocated, shipped, billed, cancelled, refunded). Extends
    /// <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPDocumentLineQuantities : ERPObjectBase
    {
        /// <summary>Initialises a new instance with all quantities set to zero.</summary>
        public ERPDocumentLineQuantities()
        {
            QuantityOrdered = 0m;
            QuantityAllocated = 0m;
            QuantityShipped = 0m;
            QuantityBilled = 0m;
            QuantityCanceled = 0m;
            QuantityRefunded = 0m;
        }

        /// <summary>Quantity ordered on the line.</summary>
        public Decimal QuantityOrdered { get; set; }
        /// <summary>Quantity allocated from stock.</summary>
        public Decimal QuantityAllocated { get; set; }
        /// <summary>Quantity shipped to the recipient.</summary>
        public Decimal QuantityShipped { get; set; }
        /// <summary>Quantity invoiced.</summary>
        public Decimal QuantityBilled { get; set; }
        /// <summary>Quantity cancelled.</summary>
        public Decimal QuantityCanceled { get; set; }
        /// <summary>Quantity refunded.</summary>
        public Decimal QuantityRefunded { get; set; }

        /// <summary>
        /// Write-only convenience setter that assigns the same value to
        /// <see cref="QuantityOrdered"/>, <see cref="QuantityAllocated"/>,
        /// <see cref="QuantityShipped"/> and <see cref="QuantityBilled"/> at once.
        /// </summary>
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

        /// <summary>Obsolete misspelled alias for <see cref="QuantityOrdered"/>.</summary>
        [Obsolete]
        public Decimal QuantitiyOrdered { get { return QuantityOrdered; } set { QuantityOrdered = value; } }
        /// <summary>Obsolete misspelled alias for <see cref="QuantityAllocated"/>.</summary>
        [Obsolete]
        public Decimal QuantitiyAllocated { get { return QuantityAllocated; } set { QuantityAllocated = value; } }
        /// <summary>Obsolete misspelled alias for <see cref="QuantityDelivered"/>.</summary>
        [Obsolete]
        public Decimal QuantitiyDelivered { get { return QuantityDelivered; } set { QuantityDelivered = value; } }
        /// <summary>Obsolete misspelled alias for <see cref="QuantityBilled"/>.</summary>
        [Obsolete]
        public Decimal QuantitiyBilled { get { return QuantityBilled; } set { QuantityBilled = value; } }

        /// <summary>Obsolete alias for <see cref="QuantityShipped"/>.</summary>
        [Obsolete]
        public Decimal QuantityDelivered { get { return QuantityShipped; } set { QuantityShipped = value; } }
    }
}
