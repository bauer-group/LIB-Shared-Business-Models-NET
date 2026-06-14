using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// A carrier-issued document (label or accompanying document) returned for a shipment, carried as
    /// inline bytes, by URI, or both — tagged with its <see cref="CarrierDocumentType"/> and
    /// <see cref="CarrierDocumentFormat"/>.
    /// </summary>
    public class CarrierDocument
    {
        /// <summary>Initialises a document from inline byte content.</summary>
        /// <param name="oContent">Raw document bytes.</param>
        /// <param name="eType">Kind of document (label or document).</param>
        /// <param name="eFormat">File format of the content.</param>
        public CarrierDocument(Byte[] oContent, CarrierDocumentType eType = CarrierDocumentType.Label, CarrierDocumentFormat eFormat = CarrierDocumentFormat.Other)
        {
            Timestamp = DateTime.UtcNow;

            Content = oContent;
            URI = null;

            Type = eType;
            Format = eFormat;
        }

        /// <summary>Initialises a document referenced by URI.</summary>
        /// <param name="oURI">Location the document can be retrieved from.</param>
        /// <param name="eType">Kind of document (label or document).</param>
        /// <param name="eFormat">File format of the content.</param>
        public CarrierDocument(Uri oURI, CarrierDocumentType eType = CarrierDocumentType.Label, CarrierDocumentFormat eFormat = CarrierDocumentFormat.Other)
        {
            Timestamp = DateTime.UtcNow;

            Content = null;
            URI = oURI;

            Type = eType;
            Format = eFormat;
        }

        /// <summary>Initialises a document carrying both inline bytes and a URI reference.</summary>
        /// <param name="oContent">Raw document bytes.</param>
        /// <param name="oURI">Location the document can be retrieved from.</param>
        /// <param name="eType">Kind of document (label or document).</param>
        /// <param name="eFormat">File format of the content.</param>
        public CarrierDocument(Byte[] oContent, Uri oURI, CarrierDocumentType eType = CarrierDocumentType.Label, CarrierDocumentFormat eFormat = CarrierDocumentFormat.Other)
        {
            Timestamp = DateTime.UtcNow;

            Content = oContent;
            URI = oURI;

            Type = eType;
            Format = eFormat;
        }

        /// <summary>Creation timestamp (UTC).</summary>
        public DateTime Timestamp { get; set; }

        /// <summary>Inline document bytes; <c>null</c> when referenced only by URI.</summary>
        public Byte[] Content { get; set; }
        /// <summary>Document location; <c>null</c> when carried only as inline bytes.</summary>
        public Uri URI { get; set; }

        /// <summary>Kind of document (label or accompanying document).</summary>
        public CarrierDocumentType Type { get; set; }
        /// <summary>File format of the document content.</summary>
        public CarrierDocumentFormat Format { get; set; }
    }
}
