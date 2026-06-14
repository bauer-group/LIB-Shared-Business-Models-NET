using System;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPDocument"/>.
    /// </summary>
    public static class ERPDocumentExtensions
    {
        /// <summary>Trims whitespace from the document and all of its nested addresses, responsible editor, custom fields and lines, in place.</summary>
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

        /// <summary>Computes the document total: discountable line totals reduced by <c>Rebate</c> (percent), plus the non-discountable line totals.</summary>
        /// <returns>The net document amount in the document's currency.</returns>
        public static Decimal TotalAmount(this ERPDocument oDocument)
        {
            var rSummaryDiscountable = oDocument.Lines.Where(p => p.Discountable == true).Sum(p => p.TotalPrice);
            var rSummaryNotDiscountable = oDocument.Lines.Where(p => p.Discountable == false).Sum(p => p.TotalPrice);

            return (rSummaryDiscountable * ((100 - oDocument.Rebate) / 100)) + rSummaryNotDiscountable;
        }

        /// <summary>Sums the net volume across all document lines.</summary>
        /// <returns>The total net volume in the lines' volume unit.</returns>
        public static Decimal TotalNetVolume(this ERPDocument oDocument)
        {
            return oDocument.Lines.Sum(p => p.Volume.NetVolume);            
        }

        /// <summary>Sums the gross volume across all document lines.</summary>
        /// <returns>The total gross volume in the lines' volume unit.</returns>
        public static Decimal TotalGrossVolume(this ERPDocument oDocument)
        {
            return oDocument.Lines.Sum(p => p.Volume.GrossVolume);
        }

        /// <summary>Sums the gross-minus-net volume difference across all document lines.</summary>
        /// <returns>The total volume difference in the lines' volume unit.</returns>
        public static Decimal TotalVolumeDifference(this ERPDocument oDocument)
        {
            return oDocument.Lines.Sum(p => p.Volume.Difference);
        }

        /// <summary>Sums the net weight across all document lines.</summary>
        /// <returns>The total net weight in the lines' weight unit.</returns>
        public static Decimal TotalNetWeight(this ERPDocument oDocument)
        {
            return oDocument.Lines.Sum(p => p.Weight.NetWeight);
        }

        /// <summary>Sums the gross weight across all document lines.</summary>
        /// <returns>The total gross weight in the lines' weight unit.</returns>
        public static Decimal TotalGrossWeight(this ERPDocument oDocument)
        {
            return oDocument.Lines.Sum(p => p.Weight.GrossWeight);
        }
    }
}
