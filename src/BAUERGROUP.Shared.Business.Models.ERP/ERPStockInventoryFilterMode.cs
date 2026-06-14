using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPStockInventoryFilterMode
    {
        None = 0,

        UID = 1,
        Reference = 2,
        Status = 3,
        ReferenceANDStatus = 4,
        PartnersReference = 5
    }
}
