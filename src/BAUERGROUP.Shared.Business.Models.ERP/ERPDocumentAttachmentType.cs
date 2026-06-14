using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Classifies the role of a file attached to an ERP document via
    /// <see cref="ERPDocumentAttachment"/>.
    /// </summary>
    public enum ERPDocumentAttachmentType
    {
        /// <summary>Attachment role not recorded.</summary>
        Unspecified = -1,

        /// <summary>An attachment that does not fit the predefined roles.</summary>
        Other = 0,

        Offer = 10,        
        Order = 20,        
        DeliveryNote = 30,        
        Invoice = 40,
        ProformaInvoice = 50,
        CreditNote = 60,

        /// <summary>Product or usage manual.</summary>
        Manual = 100,
        /// <summary>Regulatory or compliance document.</summary>
        Regulatory = 101,
        /// <summary>Technical data sheet.</summary>
        DataSheet = 102
    }
}
