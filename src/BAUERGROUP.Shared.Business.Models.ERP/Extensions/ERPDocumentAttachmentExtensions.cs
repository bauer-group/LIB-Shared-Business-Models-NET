using BAUERGROUP.Shared.Business.Models.ERP.Exceptions;
using BAUERGROUP.Shared.Business.Models.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    public static class ERPDocumentAttachmentExtensions
    {
        public static ShippingDocument FromERPDocumentAttachment(this ERPDocumentAttachment erpDocumentAttachment)
        {
            ShippingDocument sd = new ShippingDocument();

            sd.Filename = erpDocumentAttachment.Filename;
            sd.Content = erpDocumentAttachment.Content;
            sd.URI = erpDocumentAttachment.URI;
            sd.Mode = erpDocumentAttachment.Mode.FromERPAttachmentMode();

            return sd;
        }

        public static ERPDocumentAttachment FromShippingDocument(this ShippingDocument shippingDocument)
        {
            ERPDocumentAttachment da = new ERPDocumentAttachment();

            da.Name = shippingDocument.Filename;
            
            da.Filename = shippingDocument.Filename;
            da.Content = shippingDocument.Content;
            da.URI = shippingDocument.URI;

            da.Mode = shippingDocument.Mode.FromShippingDocumentMode();
            da.Type = ERPDocumentAttachmentType.Other;            

            return da;
        }

        public static ShippingDocumentMode FromERPAttachmentMode(this ERPAttachmentMode eMode)
        {
            switch (eMode)
            {
                case ERPAttachmentMode.File:
                    return ShippingDocumentMode.File;

                case ERPAttachmentMode.Embedded:
                    return ShippingDocumentMode.Embedded;

                case ERPAttachmentMode.URI:
                    return ShippingDocumentMode.URI;

                default:
                    throw new ERPNotSupportedException("Unsupported ERPAttachmentMode");
            }
        }

        public static ERPAttachmentMode FromShippingDocumentMode(this ShippingDocumentMode eMode)
        {
            switch (eMode)
            {
                case ShippingDocumentMode.File:
                    return ERPAttachmentMode.File;

                case ShippingDocumentMode.Embedded:
                    return ERPAttachmentMode.Embedded;

                case ShippingDocumentMode.URI:
                    return ERPAttachmentMode.URI;

                default:
                    throw new ERPNotSupportedException("Unsupported ERPAttachmentMode");
            }
        }
    }
}
