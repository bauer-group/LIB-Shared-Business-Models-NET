using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A min/max stock threshold. Extends <see cref="ERPStockQuantity"/> with a
    /// <see cref="ERPStockQuantityType"/> classifying which kind of limit the quantity represents.
    /// </summary>
    public class ERPStockQuantityLimit : ERPStockQuantity
    {
        /// <summary>Initialises a new instance as a <see cref="ERPStockQuantityType.MinimumStock"/> limit with an empty unit and a quantity of zero.</summary>
        public ERPStockQuantityLimit() :
            this(ERPStockQuantityType.MinimumStock, @"", 0m)
        {

        }

        /// <summary>Initialises a new instance for the given limit type, unit code and quantity.</summary>
        /// <param name="eType">Kind of stock limit this threshold represents.</param>
        /// <param name="sUnit">Stock unit code the threshold is measured in.</param>
        /// <param name="dQuantity">Threshold amount, expressed in <paramref name="sUnit"/>.</param>
        public ERPStockQuantityLimit(ERPStockQuantityType eType, string sUnit, decimal dQuantity) :
            base(sUnit, dQuantity)
        {
            Type = eType;
        }

        /// <summary>Kind of stock limit this threshold represents.</summary>
        public ERPStockQuantityType Type { get; set; }
    }
}
