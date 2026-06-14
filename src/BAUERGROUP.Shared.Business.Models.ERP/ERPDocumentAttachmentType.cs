using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPDocumentAttachmentType
    {
        Unspecified = -1,

        Other = 0,

        Offer = 10,        
        Order = 20,        
        DeliveryNote = 30,        
        Invoice = 40,
        ProformaInvoice = 50,
        CreditNote = 60,

        Manual = 100,
        Regulatory = 101,
        DataSheet = 102
    }
}
