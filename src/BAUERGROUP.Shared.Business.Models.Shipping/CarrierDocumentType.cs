using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Kind of carrier-issued document, distinguishing shipping labels from accompanying documents.
    /// </summary>
    public enum CarrierDocumentType
    {
        /// <summary>A document that is neither a label nor a standard accompanying document.</summary>
        Other = -1,

        /// <summary>A shipping label affixed to the parcel.</summary>
        Label = 0,

        /// <summary>An accompanying document (customs form, manifest, …).</summary>
        Document = 1,
    }
}
