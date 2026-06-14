using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// A generated shipping document (label, manifest, customs form, …) that can be referenced by
    /// file path, carried inline as bytes, or pointed to by URI — see <see cref="ShippingDocumentMode"/>.
    /// </summary>
    public class ShippingDocument
    {
        /// <summary>Initialises a new instance in <see cref="ShippingDocumentMode.File"/> mode with an empty filename.</summary>
        public ShippingDocument()
            : this(@"")
        {

        }

        /// <summary>Initialises a file-backed document referenced by <paramref name="sFilename"/> (<see cref="ShippingDocumentMode.File"/>).</summary>
        /// <param name="sFilename">Path or name of the document file.</param>
        /// <param name="bPrintDependingOnParcelSSCC">Whether printing is conditional on the parcel's SSCC.</param>
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

        /// <summary>Initialises a document with inline byte content (<see cref="ShippingDocumentMode.Embedded"/>).</summary>
        /// <param name="oContent">Raw document bytes.</param>
        /// <param name="bPrintDependingOnParcelSSCC">Whether printing is conditional on the parcel's SSCC.</param>
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

        /// <summary>Initialises a document referenced by URI (<see cref="ShippingDocumentMode.URI"/>).</summary>
        /// <param name="oURI">Location the document can be retrieved from.</param>
        /// <param name="bPrintDependingOnParcelSSCC">Whether printing is conditional on the parcel's SSCC.</param>
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

        /// <summary>File path or name when the document is file-backed; otherwise <c>null</c>.</summary>
        public String Filename { get; set; }

        /// <summary>Number of times the document has been printed.</summary>
        public UInt16 PrintCount { get; set; }

        /// <summary>Creation timestamp (UTC).</summary>
        public DateTime Timestamp { get; set; }

        /// <summary>Whether printing is conditional on the parcel's SSCC.</summary>
        public Boolean PrintDependingOnParcelSSCC { get; set; }

        /// <summary>Inline document bytes when embedded; otherwise <c>null</c>.</summary>
        public Byte[] Content { get; set; }
        /// <summary>Document location when referenced by URI; otherwise <c>null</c>.</summary>
        public Uri URI { get; set; }

        /// <summary>How the document payload is carried (file, embedded bytes, or URI).</summary>
        public ShippingDocumentMode Mode { get; set; }
    }
}
