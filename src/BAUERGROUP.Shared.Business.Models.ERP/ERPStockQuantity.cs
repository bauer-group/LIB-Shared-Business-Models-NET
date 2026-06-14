using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// An on-hand stock quantity of a given <see cref="ERPStockUnit"/>. Extends
    /// <see cref="ERPObjectBase"/>, pairing a stock unit with a numeric amount.
    /// </summary>
    public class ERPStockQuantity : ERPObjectBase
    {
        /// <summary>Initialises a new instance with an empty unit and a quantity of zero.</summary>
        public ERPStockQuantity() :
            this(@"", 0m)
        {

        }

        /// <summary>Initialises a new instance for the given unit code and quantity.</summary>
        /// <param name="sUnit">Stock unit code; wrapped in a new <see cref="ERPStockUnit"/>.</param>
        /// <param name="dQuantity">On-hand amount, expressed in <paramref name="sUnit"/>.</param>
        public ERPStockQuantity(string sUnit, decimal dQuantity)
        {
            Unit = new ERPStockUnit(sUnit);
            Quantity = dQuantity;
        }

        //Stock Unit
        /// <summary>Stock unit that the <see cref="Quantity"/> is measured in.</summary>
        public ERPStockUnit Unit { get; set; }
        /// <summary>On-hand amount, expressed in <see cref="Unit"/>.</summary>
        public decimal Quantity { get; set; }

        /// <summary>Deprecated misspelled alias of <see cref="Quantity"/>; reads and writes the same value.</summary>
        [Obsolete]
        public decimal Quantitiy { get { return Quantity; } set { Quantity = value; } }
    }
}
