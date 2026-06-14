using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Role-specific address overrides for an <see cref="ERPBusinessAssociate"/>. Each property
    /// holds the party to use for that role (<c>null</c> if it falls back to the main party),
    /// plus a list of further <see cref="AdditionalAddresses"/>.
    /// </summary>
    public class ERPBusinessAssociateSpecifications
    {
        /// <summary>Initialises a new instance with all role addresses unset and an empty additional-address list.</summary>
        public ERPBusinessAssociateSpecifications()
        {
            SenderAddress = null;
            ReceiverAddress = null;
            ShippingAddress = null;
            DocumentsAddress = null;
            BillingAddress = null;
            ForwarderAddress = null;
            ReturnAddress = null;

            AdditionalAddresses = new List<ERPBusinessAssociate>(0);
        }

        /// <summary>Party to use as the sender (<c>null</c> if unset).</summary>
        public ERPBusinessAssociate SenderAddress { get; set; }
        /// <summary>Party to use as the receiver (<c>null</c> if unset).</summary>
        public ERPBusinessAssociate ReceiverAddress { get; set; }
        /// <summary>Party to ship goods to (<c>null</c> if unset).</summary>
        public ERPBusinessAssociate ShippingAddress { get; set; }
        /// <summary>Party to send documents to (<c>null</c> if unset).</summary>
        public ERPBusinessAssociate DocumentsAddress { get; set; }
        /// <summary>Party to invoice (<c>null</c> if unset).</summary>
        public ERPBusinessAssociate BillingAddress { get; set; }
        /// <summary>Freight forwarder / carrier party (<c>null</c> if unset).</summary>
        public ERPBusinessAssociate ForwarderAddress { get; set; }
        /// <summary>Party to use for returns (<c>null</c> if unset).</summary>
        public ERPBusinessAssociate ReturnAddress { get; set; }

        /// <summary>Further addresses beyond the named roles above.</summary>
        public List<ERPBusinessAssociate> AdditionalAddresses { get; set; }
    }
}
