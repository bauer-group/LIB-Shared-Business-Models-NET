using System;
using BAUERGROUP.Shared.Business.Models.Shipping;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A sales or purchase business document (offer, order, delivery note, invoice, …).
    /// Extends <see cref="ERPObjectBase"/> and carries header data, party addresses, line
    /// items, attachments, shipping/payment information and status flags. The concrete
    /// document kind is given by <see cref="Type"/>.
    /// </summary>
    public class ERPDocument : ERPObjectBase
    {
        /// <summary>Initialises a new offer document with neutral defaults and empty collections.</summary>
        public ERPDocument()
        {
            Reference = @"";
            PartnersReference = @"";
            Commission = @"";
            OrderDate = DateTime.UtcNow;
            DocumentDate = DateTime.UtcNow;
            ShippingDate = DateTime.UtcNow;
            AdditionalDates = new List<ERPDocumentAdditionalDates>(0);
            Type = ERPDocumentType.Offer;
            Currency = ERPCurrency.EUR;
            Editor = null;
            Responsible = null;

            SenderAddress = null;
            ReceiverAddress = new ERPBusinessAssociate();
            ShippingAddress = null;
            DocumentsAddress = null;
            BillingAddress = null;
            ForwarderAddress = null;

            Lines = new List<ERPDocumentLine>(0);

            Attachments = new List<ERPDocumentAttachment>(0);

            Links = new List<ERPObjectLink>(0);
            
            CustomFields = new List<ERPCustomField>(0);

            Rebate = 0m;

            PreliminaryRemark = @"";
            ConcludingRemark = @"";

            ShippingInformation = new List<Parcel>(0);
            ShippingStatus = new List<ParcelShippingStatus>(0);
            ShippingInstruction = ERPShippingInstruction.None;
            DeliveryInstruction = null;
            ShippingValue = null;

            PaymentTherms = new ERPPaymentTherms();

            Flag = ERPDocumentFlags.None;

            CommercialRepresentative = null;

            OrderMethod = ERPCommunicationType.Unkown;

            Status = ERPDocumentProcessingStatus.Unprocessed;

            DocumentStatus = ERPObjectStatus.None;

            PricesWithoutVAT = true;

            Payments = new List<ERPPaymentStatus>(0);

            StatusDetail = new ERPStatusDetails();

            TransactionNumber = Guid.Empty;

            SalesChannel = null;
        }

        /// <summary>Our own reference for the document. Free-text.</summary>
        public String Reference { get; set; }
        /// <summary>The business partner's reference for the document. Free-text.</summary>
        public String PartnersReference { get; set; }

        /// <summary>Commission / project reference. Free-text.</summary>
        public String Commission { get; set; }
                /// <summary>Date the order was placed.</summary>
                public DateTime OrderDate { get; set; }
        /// <summary>Date printed on the document.</summary>
        public DateTime DocumentDate { get; set; }
        /// <summary>Planned shipping date (<c>null</c> if not set).</summary>
        public DateTime? ShippingDate { get; set; }
        /// <summary>Additional typed dates beyond the standard order/document/shipping dates.</summary>
        public List<ERPDocumentAdditionalDates> AdditionalDates { get; set; }

        /// <summary>Business type of the document (offer, order, invoice, …).</summary>
        public ERPDocumentType Type { get; set; }
        /// <summary>Currency for all monetary amounts on the document.</summary>
        public ERPCurrency Currency { get; set; }
        /// <summary>User who created or last edited the document.</summary>
        public ERPEditor Editor { get; set; }
        /// <summary>User responsible for the document.</summary>
        public ERPEditor Responsible { get; set; }

        /// <summary>Lifecycle status bitfield of the document (<see cref="ERPObjectStatus"/>).</summary>
        public ERPObjectStatus DocumentStatus { get; set; }

        /// <summary>Convenience accessor for the <see cref="ERPObjectStatus.Obsolete"/> flag in <see cref="DocumentStatus"/>.</summary>
        public Boolean IsObsolete { get { return DocumentStatus.HasFlag(ERPObjectStatus.Obsolete); } set { if (value) DocumentStatus |= ERPObjectStatus.Obsolete; else DocumentStatus &= ~ERPObjectStatus.Obsolete; } }
        /// <summary>Convenience accessor for the <see cref="ERPObjectStatus.Cancelled"/> flag in <see cref="DocumentStatus"/>.</summary>
        public Boolean IsCancelled { get { return DocumentStatus.HasFlag(ERPObjectStatus.Cancelled); } set { if (value) DocumentStatus |= ERPObjectStatus.Cancelled; else DocumentStatus &= ~ERPObjectStatus.Cancelled; } }
        /// <summary>Convenience accessor for the <see cref="ERPObjectStatus.Draft"/> flag in <see cref="DocumentStatus"/>.</summary>
        public Boolean IsDraft { get { return DocumentStatus.HasFlag(ERPObjectStatus.Draft); } set { if (value) DocumentStatus |= ERPObjectStatus.Draft; else DocumentStatus &= ~ERPObjectStatus.Draft; } }
        /// <summary>Convenience accessor for the <see cref="ERPObjectStatus.Continued"/> flag in <see cref="DocumentStatus"/>.</summary>
        public Boolean IsContinued { get { return DocumentStatus.HasFlag(ERPObjectStatus.Continued); } set { if (value) DocumentStatus |= ERPObjectStatus.Continued; else DocumentStatus &= ~ERPObjectStatus.Continued; } }
        /// <summary>Convenience accessor for the <see cref="ERPObjectStatus.Deleted"/> flag in <see cref="DocumentStatus"/>.</summary>
        public Boolean IsDeleted { get { return DocumentStatus.HasFlag(ERPObjectStatus.Deleted); } set { if (value) DocumentStatus |= ERPObjectStatus.Deleted; else DocumentStatus &= ~ERPObjectStatus.Deleted; } }
        /// <summary>Convenience accessor for the <see cref="ERPObjectStatus.Booked"/> flag in <see cref="DocumentStatus"/>.</summary>
        public Boolean IsBooked { get { return DocumentStatus.HasFlag(ERPObjectStatus.Booked); } set { if (value) DocumentStatus |= ERPObjectStatus.Booked; else DocumentStatus &= ~ERPObjectStatus.Booked; } }

        /// <summary>Sending party (<c>null</c> if not set).</summary>
        public ERPBusinessAssociate SenderAddress { get; set; }
        /// <summary>Receiving party / main document recipient.</summary>
        public ERPBusinessAssociate ReceiverAddress { get; set; }
        /// <summary>Ship-to party (<c>null</c> if not set).</summary>
        public ERPBusinessAssociate ShippingAddress { get; set; }
        /// <summary>Party the documents are sent to (<c>null</c> if not set).</summary>
        public ERPBusinessAssociate DocumentsAddress { get; set; }
        /// <summary>Bill-to party (<c>null</c> if not set).</summary>
        public ERPBusinessAssociate BillingAddress { get; set; }
        /// <summary>Forwarder / carrier party (<c>null</c> if not set).</summary>
        public ERPBusinessAssociate ForwarderAddress { get; set; }
        
        /// <summary>Line items of the document.</summary>
        public List<ERPDocumentLine> Lines { get; set; }
        /// <summary>Files attached to the document.</summary>
        public List<ERPDocumentAttachment> Attachments { get; set; }
        /// <summary>Loose links to related objects.</summary>
        public List<ERPObjectLink> Links { get; set; }
        
        /// <summary>Custom fields carried by the document.</summary>
        public List<ERPCustomField> CustomFields { get; set; }

        /// <summary>Document-level rebate as a percentage.</summary>
        public Decimal Rebate { get; set; }

        /// <summary>Remark printed before the line items. Free-text.</summary>
        public String PreliminaryRemark { get; set; }
        /// <summary>Remark printed after the line items. Free-text.</summary>
        public String ConcludingRemark { get; set; }

        /// <summary>Parcels making up the shipment for this document.</summary>
        public List<Parcel> ShippingInformation { get; set; }
        /// <summary>Per-parcel shipping status entries.</summary>
        public List<ParcelShippingStatus> ShippingStatus { get; set; }
        /// <summary>Instruction governing how the document is shipped.</summary>
        public ERPShippingInstruction ShippingInstruction { get; set; }
        /// <summary>Delivery instruction for the document (<c>null</c> if not set).</summary>
        public ERPDeliveryInstruction DeliveryInstruction { get; set; }

        /// <summary>Declared shipping value in the document's currency (<c>null</c> if not set).</summary>
        public Decimal? ShippingValue { get; set; }

        /// <summary>Payment terms applied to the document.</summary>
        public ERPPaymentTherms PaymentTherms { get; set; }

        /// <summary>User-assignable classification flag (<see cref="ERPDocumentFlags"/>).</summary>
        public ERPDocumentFlags Flag { get; set; }

        /// <summary>Commercial representative associated with the document (<c>null</c> if not set).</summary>
        public ERPCommercialRepresentative CommercialRepresentative { get; set; }

        /// <summary>Channel through which the order was received.</summary>
        public ERPCommunicationType OrderMethod { get; set; }

        /// <summary>Workflow processing state of the document.</summary>
        public ERPDocumentProcessingStatus Status { get; set; }        

        /// <summary>Whether line and total prices exclude VAT (net pricing).</summary>
        public Boolean PricesWithoutVAT { get; set; }

        /// <summary>Payment status entries recorded against the document.</summary>
        public List<ERPPaymentStatus> Payments { get; set; }

        /// <summary>Detailed status breakdown for the document.</summary>
        public ERPStatusDetails StatusDetail { get; set; }        

        /// <summary>Transaction grouping identifier (<see cref="Guid.Empty"/> if not set).</summary>
        public Guid TransactionNumber { get; set; }

        /// <summary>Sales channel the document originates from (<c>null</c> if not set).</summary>
        public ERPSalesChannel SalesChannel { get; set; }
    }
}
