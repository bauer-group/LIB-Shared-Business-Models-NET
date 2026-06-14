using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Classification of an <see cref="ERPStockUnit"/> by its role in the warehouse.
    /// </summary>
    public enum ERPStockUnitType
    {
        /// <summary>Unit used for warehousing/storage.</summary>
        StorageUnit = 1,
        /// <summary>Unit used as a sales quantity.</summary>
        SaleUnit = 2,
        /// <summary>Unit used for delivery/dispatch.</summary>
        DeliveryUnit = 3
    }
}
