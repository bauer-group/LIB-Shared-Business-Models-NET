using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A trading party (customer, supplier, etc.). Extends <see cref="ERPAddress"/>, so it carries
    /// the full address/contact surface and adds the commercial attributes — currency, language,
    /// VAT/tax ids, payment terms, bank accounts, sales rep, attachments and address specifications.
    /// </summary>
    public class ERPBusinessAssociate: ERPAddress
    {
        /// <summary>Initialises a new associate with neutral defaults (EUR currency, German language, letter-mail dispatch, sales tax applied, <see cref="ERPBusinessAssociateType.Other"/>).</summary>
        public ERPBusinessAssociate()
        {
            PartnersReference = @"";
            ContactPerson = @"";

            Currency = ERPCurrency.EUR;

            DocumentsSendMethods = new List<ERPCommunicationType>(0);
            DocumentsSendMethods.Add(ERPCommunicationType.LetterMail);

            Language = ERPLanguage.German;

            VATID = TaxID = @"";

            CustomFields = new List<ERPCustomField>(0);

            PaymentTherms = new ERPPaymentTherms();

            CommercialRepresentative = null;

            SalesTaxApply = true;

            BusinessType = ERPBusinessAssociateType.Other;

            PriceGroup = null;

            CostCenter = @"";
            CostObjects = @"";

            BankAccounts = new List<ERPBankAccount>(0);
            PaymentMethod = ERPPaymentType.Unspecified;

            Homepage = @"";

            Specifications = new ERPBusinessAssociateSpecifications();
            
            Attachments = new List<ERPBusinessAssociateAttachment>(0);

            ProcessingInstructions = new List<ERPProcessingInstruction>(0);
        }

        /// <summary>Reference number assigned to us by the partner (our id in their system).</summary>
        public string PartnersReference { get; set; }

        /// <summary>Primary contact person at the party.</summary>
        public string ContactPerson { get; set; }

        /// <summary>Default transaction currency for the party.</summary>
        public ERPCurrency Currency { get; set; }

        /// <summary>Assigned price group (<c>null</c> if none).</summary>
        public ERPPriceGroup PriceGroup { get; set; }

        /// <summary>Default cost center for postings.</summary>
        public string CostCenter { get; set; }
        /// <summary>Default cost object(s) for postings.</summary>
        public string CostObjects { get; set; }

        /// <summary>Channels by which documents are sent to the party (defaults to letter mail).</summary>
        public List<ERPCommunicationType> DocumentsSendMethods { get; set; }

        /// <summary>Preferred correspondence language.</summary>
        public ERPLanguage Language { get; set; }

        /// <summary>VAT identification number.</summary>
        public string VATID { get; set; }
        /// <summary>Tax / fiscal identification number.</summary>
        public string TaxID { get; set; }

        /// <summary>Additional user-defined fields.</summary>
        public List<ERPCustomField> CustomFields { get; set; }

        /// <summary>Payment terms (due dates, discounts, …).</summary>
        public ERPPaymentTherms PaymentTherms { get; set; }

        /// <summary>Assigned sales representative (<c>null</c> if none).</summary>
        public ERPCommercialRepresentative CommercialRepresentative { get; set; }

        /// <summary>Whether sales tax applies to transactions with this party.</summary>
        public bool SalesTaxApply { get; set; }

        /// <summary>Party classification (customer, supplier, …).</summary>
        public ERPBusinessAssociateType BusinessType { get; set; }

        /// <summary>Bank accounts on file for the party.</summary>
        public List<ERPBankAccount> BankAccounts { get; set; }
        /// <summary>Default payment method.</summary>
        public ERPPaymentType PaymentMethod { get; set; }

        /// <summary>Website / homepage URL.</summary>
        public string Homepage { get; set; }

        /// <summary>Role-specific address overrides (billing, shipping, …) and additional addresses.</summary>
        public ERPBusinessAssociateSpecifications Specifications { get; set; }

        /// <summary>Documents attached to the party.</summary>
        public List<ERPBusinessAssociateAttachment> Attachments { get; set; }

        /// <summary>Processing instructions applied when handling the party.</summary>
        public List<ERPProcessingInstruction> ProcessingInstructions { get; set; }
    }
}
