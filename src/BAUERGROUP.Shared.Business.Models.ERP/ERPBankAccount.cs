using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPBankAccount : ERPObjectBase
    {
        public ERPBankAccount()
        {
            AccountNumber = BankCodeNumber = IBAN = BIC = Beneficiary = BankName  = Comment = @"";
            Enabled = true;
            Preset = true;
        }

        public string AccountNumber { get; set; }
        public string BankCodeNumber { get; set; }

        public string IBAN { get; set; }
        public string BIC { get; set; }

        public string Beneficiary { get; set; }

        public string BankName { get; set; }

        public string Comment { get; set; }

        public bool Enabled { get; set; }
        public bool Preset { get; set; }
    }
}
