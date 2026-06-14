using System;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    public static class ERPDocumentExtensions
    {
        public static void Trim(this ERPDocument erpDocument)
        {
            erpDocument.TrimPublicStringProperties();

            if (erpDocument.SenderAddress != null)
                erpDocument.SenderAddress.Trim();

            if (erpDocument.ReceiverAddress != null)
                erpDocument.ReceiverAddress.Trim();

            if (erpDocument.DocumentsAddress != null)
                erpDocument.DocumentsAddress.Trim();

            if (erpDocument.ShippingAddress != null)
                erpDocument.ShippingAddress.Trim();

            if (erpDocument.ForwarderAddress != null)
                erpDocument.ForwarderAddress.Trim();

            if (erpDocument.BillingAddress != null)
                erpDocument.BillingAddress.Trim();

            if (erpDocument.Responsible != null)
                erpDocument.Responsible.Trim();

            erpDocument.CustomFields.Trim();

            if (erpDocument.Lines != null)
                erpDocument.Lines.Trim();
        }

        public static Decimal TotalAmount(this ERPDocument oDocument)
        {
            var rSummaryDiscountable = oDocument.Lines.Where(p => p.Discountable == true).Sum(p => p.TotalPrice);
            var rSummaryNotDiscountable = oDocument.Lines.Where(p => p.Discountable == false).Sum(p => p.TotalPrice);

            return (rSummaryDiscountable * ((100 - oDocument.Rebate) / 100)) + rSummaryNotDiscountable;
        }

        public static Decimal TotalNetVolume(this ERPDocument oDocument)
        {
            return oDocument.Lines.Sum(p => p.Volume.NetVolume);            
        }

        public static Decimal TotalGrossVolume(this ERPDocument oDocument)
        {
            return oDocument.Lines.Sum(p => p.Volume.GrossVolume);
        }

        public static Decimal TotalVolumeDifference(this ERPDocument oDocument)
        {
            return oDocument.Lines.Sum(p => p.Volume.Difference);
        }

        public static Decimal TotalNetWeight(this ERPDocument oDocument)
        {
            return oDocument.Lines.Sum(p => p.Weight.NetWeight);
        }

        public static Decimal TotalGrossWeight(this ERPDocument oDocument)
        {
            return oDocument.Lines.Sum(p => p.Weight.GrossWeight);
        }
    }
}
