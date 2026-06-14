using System;
using BAUERGROUP.Shared.Business.Models.ERP.Exceptions;
using BAUERGROUP.Shared.Business.Models.Shipping;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPDocumentAttachment"/>.
    /// </summary>
    public static class ERPDocumentAttachmentExtensions
    {
        /// <summary>Projects an <see cref="ERPDocumentAttachment"/> onto a shipping <see cref="ShippingDocument"/>.</summary>
        /// <returns>A new <see cref="ShippingDocument"/> populated from the attachment.</returns>
        public static ShippingDocument FromERPDocumentAttachment(this ERPDocumentAttachment erpDocumentAttachment)
        {
            ShippingDocument sd = new ShippingDocument();

            sd.Filename = erpDocumentAttachment.Filename;
            sd.Content = erpDocumentAttachment.Content;
            sd.URI = erpDocumentAttachment.URI;
            sd.Mode = erpDocumentAttachment.Mode.FromERPAttachmentMode();

            return sd;
        }

        /// <summary>Projects a shipping <see cref="ShippingDocument"/> onto an <see cref="ERPDocumentAttachment"/>, defaulting its type to <see cref="ERPDocumentAttachmentType.Other"/>.</summary>
        /// <returns>A new <see cref="ERPDocumentAttachment"/> populated from the shipping document.</returns>
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

        /// <summary>Maps an <see cref="ERPAttachmentMode"/> to the equivalent <see cref="ShippingDocumentMode"/>.</summary>
        /// <returns>The matching <see cref="ShippingDocumentMode"/>.</returns>
        /// <exception cref="ERPNotSupportedException">Thrown when <paramref name="eMode"/> has no shipping-side equivalent.</exception>
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

        /// <summary>Maps a <see cref="ShippingDocumentMode"/> to the equivalent <see cref="ERPAttachmentMode"/>.</summary>
        /// <returns>The matching <see cref="ERPAttachmentMode"/>.</returns>
        /// <exception cref="ERPNotSupportedException">Thrown when <paramref name="eMode"/> has no ERP-side equivalent.</exception>
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
