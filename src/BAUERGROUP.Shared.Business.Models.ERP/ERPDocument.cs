using BAUERGROUP.Shared.Business.Models.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPDocument : ERPObjectBase
    {
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

        public String Reference { get; set; }
        public String PartnersReference { get; set; }

        public String Commission { get; set; }
                public DateTime OrderDate { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime? ShippingDate { get; set; }
        public List<ERPDocumentAdditionalDates> AdditionalDates { get; set; }

        public ERPDocumentType Type { get; set; }
        public ERPCurrency Currency { get; set; }
        public ERPEditor Editor { get; set; }
        public ERPEditor Responsible { get; set; }

        public ERPObjectStatus DocumentStatus { get; set; }

        public Boolean IsObsolete { get { return DocumentStatus.HasFlag(ERPObjectStatus.Obsolete); } set { if (value) DocumentStatus |= ERPObjectStatus.Obsolete; else DocumentStatus &= ~ERPObjectStatus.Obsolete; } }
        public Boolean IsCancelled { get { return DocumentStatus.HasFlag(ERPObjectStatus.Cancelled); } set { if (value) DocumentStatus |= ERPObjectStatus.Cancelled; else DocumentStatus &= ~ERPObjectStatus.Cancelled; } }
        public Boolean IsDraft { get { return DocumentStatus.HasFlag(ERPObjectStatus.Draft); } set { if (value) DocumentStatus |= ERPObjectStatus.Draft; else DocumentStatus &= ~ERPObjectStatus.Draft; } }
        public Boolean IsContinued { get { return DocumentStatus.HasFlag(ERPObjectStatus.Continued); } set { if (value) DocumentStatus |= ERPObjectStatus.Continued; else DocumentStatus &= ~ERPObjectStatus.Continued; } }
        public Boolean IsDeleted { get { return DocumentStatus.HasFlag(ERPObjectStatus.Deleted); } set { if (value) DocumentStatus |= ERPObjectStatus.Deleted; else DocumentStatus &= ~ERPObjectStatus.Deleted; } }
        public Boolean IsBooked { get { return DocumentStatus.HasFlag(ERPObjectStatus.Booked); } set { if (value) DocumentStatus |= ERPObjectStatus.Booked; else DocumentStatus &= ~ERPObjectStatus.Booked; } }

        public ERPBusinessAssociate SenderAddress { get; set; }
        public ERPBusinessAssociate ReceiverAddress { get; set; }
        public ERPBusinessAssociate ShippingAddress { get; set; }
        public ERPBusinessAssociate DocumentsAddress { get; set; }
        public ERPBusinessAssociate BillingAddress { get; set; }
        public ERPBusinessAssociate ForwarderAddress { get; set; }
        
        public List<ERPDocumentLine> Lines { get; set; }
        public List<ERPDocumentAttachment> Attachments { get; set; }
        public List<ERPObjectLink> Links { get; set; }
        
        public List<ERPCustomField> CustomFields { get; set; }

        public Decimal Rebate { get; set; }

        public String PreliminaryRemark { get; set; }
        public String ConcludingRemark { get; set; }

        public List<Parcel> ShippingInformation { get; set; }
        public List<ParcelShippingStatus> ShippingStatus { get; set; }
        public ERPShippingInstruction ShippingInstruction { get; set; }
        public ERPDeliveryInstruction DeliveryInstruction { get; set; }

        public Decimal? ShippingValue { get; set; }

        public ERPPaymentTherms PaymentTherms { get; set; }

        public ERPDocumentFlags Flag { get; set; }

        public ERPCommercialRepresentative CommercialRepresentative { get; set; }

        public ERPCommunicationType OrderMethod { get; set; }

        public ERPDocumentProcessingStatus Status { get; set; }        

        public Boolean PricesWithoutVAT { get; set; }

        public List<ERPPaymentStatus> Payments { get; set; }

        public ERPStatusDetails StatusDetail { get; set; }        

        public Guid TransactionNumber { get; set; }

        public ERPSalesChannel SalesChannel { get; set; }
    }
}
