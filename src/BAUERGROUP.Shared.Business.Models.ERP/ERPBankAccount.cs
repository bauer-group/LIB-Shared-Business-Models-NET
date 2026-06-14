using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Bank account details (IBAN/BIC and legacy account/bank-code numbers) for a party.
    /// Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPBankAccount : ERPObjectBase
    {
        /// <summary>Initialises a new instance with empty fields, enabled and preset by default.</summary>
        public ERPBankAccount()
        {
            AccountNumber = BankCodeNumber = IBAN = BIC = Beneficiary = BankName  = Comment = @"";
            Enabled = true;
            Preset = true;
        }

        /// <summary>Legacy domestic account number.</summary>
        public string AccountNumber { get; set; }
        /// <summary>Legacy bank/sort code number.</summary>
        public string BankCodeNumber { get; set; }

        /// <summary>International Bank Account Number.</summary>
        public string IBAN { get; set; }
        /// <summary>Bank Identifier Code (SWIFT).</summary>
        public string BIC { get; set; }

        /// <summary>Account holder / beneficiary name.</summary>
        public string Beneficiary { get; set; }

        /// <summary>Name of the bank.</summary>
        public string BankName { get; set; }

        /// <summary>Free-text comment.</summary>
        public string Comment { get; set; }

        /// <summary>Whether the account is active for use.</summary>
        public bool Enabled { get; set; }
        /// <summary>Whether this is the preset / default account.</summary>
        public bool Preset { get; set; }
    }
}
