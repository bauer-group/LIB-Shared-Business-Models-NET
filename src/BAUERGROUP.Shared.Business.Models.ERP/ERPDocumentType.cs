using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPDocumentType
    {
        //Customer
        Offer = 100,
        AdditionalOffer = 120,

        OrderEnquiry = 140,
        Order = 160,
        ServiceOrder = 180,
        RepairOrder = 200,
        OrderConfirmation = 220,
        AdditionalOrderConfirmation = 240,
        
        OutgoingGoods = 260,
        DeliveryNote = 280,
        ReturnDeliveryNote = 290,
        
        Invoice = 300,
        ConsolidatedInvoice = 320,
        PartInvoice = 340,
        FinalAccount = 360,        
        CreditNote = 380,        
        ProgressInvoice = 400,
        ProformaInvoice = 420,
        CancellationInvoice = 440,
        EstimateOfCost = 460,

        //Supplier
        SuppliersOrderEnquiry = 600,
        SuppliersOrder = 620,
        IncomingGoods = 640,
        IncomingInvoice = 660,
        SuppliersReturn = 680,
        SuppliersCreditNote = 700

        //Production

        //Warehouse
    }
}
