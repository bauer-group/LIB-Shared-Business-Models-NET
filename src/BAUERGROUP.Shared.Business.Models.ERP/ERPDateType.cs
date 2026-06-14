using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Classifies the business meaning of a date in an ERP document or process.
    /// </summary>
    public enum ERPDateType
    {
        /// <summary>Date type not classified.</summary>
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

        /// <summary>Start of the customer's requested delivery window.</summary>
        DesiredDeliveryDateStart = 2000,
        /// <summary>End of the customer's requested delivery window.</summary>
        DesiredDeliveryDateEnd = 2001
    }
}
