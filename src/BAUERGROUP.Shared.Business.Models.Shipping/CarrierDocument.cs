using System;
using System.Collections.Generic;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class CarrierDocument
    {
        public CarrierDocument(Byte[] oContent, CarrierDocumentType eType = CarrierDocumentType.Label, CarrierDocumentFormat eFormat = CarrierDocumentFormat.Other)
        {
            Timestamp = DateTime.UtcNow;

            Content = oContent;
            URI = null;

            Type = eType;
            Format = eFormat;
        }

        public CarrierDocument(Uri oURI, CarrierDocumentType eType = CarrierDocumentType.Label, CarrierDocumentFormat eFormat = CarrierDocumentFormat.Other)
        {
            Timestamp = DateTime.UtcNow;

            Content = null;
            URI = oURI;

            Type = eType;
            Format = eFormat;
        }

        public CarrierDocument(Byte[] oContent, Uri oURI, CarrierDocumentType eType = CarrierDocumentType.Label, CarrierDocumentFormat eFormat = CarrierDocumentFormat.Other)
        {
            Timestamp = DateTime.UtcNow;

            Content = oContent;
            URI = oURI;

            Type = eType;
            Format = eFormat;
        }

        public DateTime Timestamp { get; set; }

        public Byte[] Content { get; set; }
        public Uri URI { get; set; }

        public CarrierDocumentType Type { get; set; }
        public CarrierDocumentFormat Format { get; set; }
    }
}
