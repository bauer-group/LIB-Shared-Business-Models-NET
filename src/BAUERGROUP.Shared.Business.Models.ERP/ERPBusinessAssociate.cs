using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPBusinessAssociate: ERPAddress
    {
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

        public string PartnersReference { get; set; }

        public string ContactPerson { get; set; }

        public ERPCurrency Currency { get; set; }

        public ERPPriceGroup PriceGroup { get; set; }
        
        public string CostCenter { get; set; }
        public string CostObjects { get; set; }

        public List<ERPCommunicationType> DocumentsSendMethods { get; set; }

        public ERPLanguage Language { get; set; }

        public string VATID { get; set; }
        public string TaxID { get; set; }

        public List<ERPCustomField> CustomFields { get; set; }

        public ERPPaymentTherms PaymentTherms { get; set; }

        public ERPCommercialRepresentative CommercialRepresentative { get; set; }

        public bool SalesTaxApply { get; set; }

        public ERPBusinessAssociateType BusinessType { get; set; }

        public List<ERPBankAccount> BankAccounts { get; set; }
        public ERPPaymentType PaymentMethod { get; set; }

        public string Homepage { get; set; }

        public ERPBusinessAssociateSpecifications Specifications { get; set; }

        public List<ERPBusinessAssociateAttachment> Attachments { get; set; }

        public List<ERPProcessingInstruction> ProcessingInstructions { get; set; }
    }
}
