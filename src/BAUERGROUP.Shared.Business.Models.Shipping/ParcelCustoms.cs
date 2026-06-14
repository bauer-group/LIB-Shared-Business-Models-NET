using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class ParcelCustoms
    {
        public ParcelCustoms()
        {
            InvoiceNumber = null;
            
            Currency = "EUR";

            ShippingFee = 0m;

            Type = ParcelCustomsType.CommercialGoods;
            TypeDescription = null;

            PlaceOfShipment = null;

            PermitNumber = null;
            AttestationNumber = null;
            CustomsReferenceSender = null;
            CustomsReferenceReceiver = null;

            TradeTerms = null;

            Lines = new List<ParcelCustomsLine>();
        }

        public String InvoiceNumber { get; set; }
        
        public String Currency { get; set; }

        public Decimal ShippingFee { get; set; }

        public ParcelCustomsType Type { get; set; }
        public String TypeDescription { get; set; }

        public String PlaceOfShipment { get; set; }

        public String PermitNumber { get; set; }
        public String AttestationNumber { get; set; }
        public String CustomsReferenceReceiver { get; set; }
        public String CustomsReferenceSender { get; set; }

        public FreightTermsOfTrade? TradeTerms { get; set; }

        public List<ParcelCustomsLine> Lines { get; set; }
    }
}