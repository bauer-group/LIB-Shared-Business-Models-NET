using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPDocumentLineDeliveryStatus
    {
        Unknown = 0,

        Open = 10,
        Planned = 20,
        Reserved = 40,
        Allocated = 60,
        Loaded = 80,
        Shipped = 100,
        Delivered = 120,

        Cancelled = 200,

        Internal = 800
    }
}
