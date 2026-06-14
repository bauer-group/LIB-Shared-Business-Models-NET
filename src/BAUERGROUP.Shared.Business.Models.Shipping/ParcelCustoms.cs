using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Customs declaration for a cross-border parcel — invoice, fees, classification and line items.
    /// </summary>
    public class ParcelCustoms
    {
        /// <summary>Initialises a new instance with neutral defaults and an empty line collection.</summary>
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

        /// <summary>Commercial invoice number for the shipment (<c>null</c> if not set).</summary>
        public String InvoiceNumber { get; set; }

        /// <summary>ISO currency code of the declared values (defaults to <c>EUR</c>).</summary>
        public String Currency { get; set; }

        /// <summary>Shipping/freight fee declared to customs, in <see cref="Currency"/>.</summary>
        public Decimal ShippingFee { get; set; }

        /// <summary>Customs category of the parcel contents.</summary>
        public ParcelCustomsType Type { get; set; }
        /// <summary>Free-text description for the customs type, typically used with <see cref="ParcelCustomsType.Other"/> (<c>null</c> if not set).</summary>
        public String TypeDescription { get; set; }

        /// <summary>Place from which the goods are shipped (<c>null</c> if not set).</summary>
        public String PlaceOfShipment { get; set; }

        /// <summary>Export/import permit number (<c>null</c> if not set).</summary>
        public String PermitNumber { get; set; }
        /// <summary>Attestation number for the declaration (<c>null</c> if not set).</summary>
        public String AttestationNumber { get; set; }
        /// <summary>Receiver-side customs reference (<c>null</c> if not set).</summary>
        public String CustomsReferenceReceiver { get; set; }
        /// <summary>Sender-side customs reference (<c>null</c> if not set).</summary>
        public String CustomsReferenceSender { get; set; }

        /// <summary>Incoterms trade terms governing the shipment (<c>null</c> if not set).</summary>
        public FreightTermsOfTrade? TradeTerms { get; set; }

        /// <summary>Itemised customs line entries for the parcel's contents.</summary>
        public List<ParcelCustomsLine> Lines { get; set; }
    }
}