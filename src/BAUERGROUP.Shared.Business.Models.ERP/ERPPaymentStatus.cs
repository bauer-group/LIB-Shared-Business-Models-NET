using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPPaymentStatus : ERPObjectBase
    {
        public ERPPaymentStatus()
        {
            BookingReference = @"";
            PaymentReference = @"";
            ValueDate = null;
            BookingDate = null;
            Amount = 0m;
            Method = ERPPaymentType.Unspecified;
            PartnerAccount = null;
        }

        public string BookingReference { get; set; }
        public string PaymentReference { get; set; }

        public DateTime? ValueDate { get; set; }
        public DateTime? BookingDate { get; set; }

        public decimal Amount { get; set; }        
        
        public ERPPaymentType Method { get; set; }
        public ERPBankAccount PartnerAccount { get; set; }
    }
}
