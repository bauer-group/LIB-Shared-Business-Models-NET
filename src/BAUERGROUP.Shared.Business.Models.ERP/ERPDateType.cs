using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPDateType
    {
        Unkown = 0,

        Order = 10,        
        Confirmation = 20,
        Allocated = 30,
        Shipping = 40,        
        Paid = 90,
        
        InboundDelivery = 400,
        OutboundDelivery = 500,

        Loading = 700,
        GoodIssue = 800,
        Picking = 900,
        TransportationPlanning = 1000,

        DesiredDeliveryDateStart = 2000,
        DesiredDeliveryDateEnd = 2001
    }
}
