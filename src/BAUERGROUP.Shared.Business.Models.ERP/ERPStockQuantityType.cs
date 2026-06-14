using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Classifies which kind of stock threshold a <see cref="ERPStockQuantityLimit"/> represents.
    /// </summary>
    public enum ERPStockQuantityType
    {
        /// <summary>Lowest on-hand level the stock should not fall below.</summary>
        MinimumStock = 1,
        /// <summary>Level at which a new order should be placed.</summary>
        OrderPoint = 2,
        /// <summary>Level at which replenishment should be triggered.</summary>
        ReorderPoint = 3,
    }
}
