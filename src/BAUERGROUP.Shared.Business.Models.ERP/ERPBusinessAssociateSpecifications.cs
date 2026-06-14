using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPBusinessAssociateSpecifications
    {
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

        public ERPBusinessAssociate SenderAddress { get; set; }
        public ERPBusinessAssociate ReceiverAddress { get; set; }
        public ERPBusinessAssociate ShippingAddress { get; set; }
        public ERPBusinessAssociate DocumentsAddress { get; set; }
        public ERPBusinessAssociate BillingAddress { get; set; }
        public ERPBusinessAssociate ForwarderAddress { get; set; }
        public ERPBusinessAssociate ReturnAddress { get; set; }

        public List<ERPBusinessAssociate> AdditionalAddresses { get; set; }
    }
}
