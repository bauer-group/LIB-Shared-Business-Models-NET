using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class ShippingDocument
    {
        public ShippingDocument()
            : this(@"")
        {
            
        }

        public ShippingDocument(String sFilename, Boolean bPrintDependingOnParcelSSCC = false)
        {            
            Filename = sFilename;

            PrintCount = 0;
            Timestamp = DateTime.UtcNow;
            PrintDependingOnParcelSSCC = bPrintDependingOnParcelSSCC;

            Content = null;
            URI = null;

            Mode = ShippingDocumentMode.File;
        }

        public ShippingDocument(Byte[] oContent, Boolean bPrintDependingOnParcelSSCC = false)
        {
            Filename = null;

            PrintCount = 0;
            Timestamp = DateTime.UtcNow;
            PrintDependingOnParcelSSCC = bPrintDependingOnParcelSSCC;

            Content = oContent;
            URI = null;

            Mode = ShippingDocumentMode.Embedded;
        }

        public ShippingDocument(Uri oURI, Boolean bPrintDependingOnParcelSSCC = false)
        {
            Filename = null;

            PrintCount = 0;
            Timestamp = DateTime.UtcNow;
            PrintDependingOnParcelSSCC = bPrintDependingOnParcelSSCC;

            Content = null;
            URI = oURI;

            Mode = ShippingDocumentMode.URI;
        }

        public String Filename { get; set; }

        public UInt16 PrintCount { get; set; }

        public DateTime Timestamp { get; set; }

        public Boolean PrintDependingOnParcelSSCC { get; set; }

        public Byte[] Content { get; set; }
        public Uri URI { get; set; }

        public ShippingDocumentMode Mode { get; set; }
    }
}
