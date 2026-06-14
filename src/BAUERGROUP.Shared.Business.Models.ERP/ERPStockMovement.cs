using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A goods movement (in / out / transfer). Extends <see cref="ERPStockInventory"/> and adds
    /// the movement timestamp, links, processing status and a transaction grouping key.
    /// </summary>
    public class ERPStockMovement : ERPStockInventory
    {
        /// <summary>Initialises a new movement with the current UTC timestamp and unprocessed status.</summary>
        public ERPStockMovement()
        {
            Timestamp = DateTime.UtcNow;

            Links = new List<ERPObjectLink>(0);

            Status = ERPDocumentProcessingStatus.Unprocessed;
            TransactionNumber = Guid.Empty;
        }

        /// <summary>Moment the movement occurred, in UTC.</summary>
        public DateTime Timestamp { get; set; }

        /// <summary>Loose links to related objects (documents, other movements, …).</summary>
        public List<ERPObjectLink> Links { get; set; }

        /// <summary>Processing status of the movement.</summary>
        public ERPDocumentProcessingStatus Status { get; set; }
        /// <summary>Key grouping movements of the same transaction (<see cref="Guid.Empty"/> if not set).</summary>
        public Guid TransactionNumber { get; set; }
    }
}
