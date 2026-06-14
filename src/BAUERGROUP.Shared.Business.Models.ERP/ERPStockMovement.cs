using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPStockMovement : ERPStockInventory
    {
        public ERPStockMovement()
        {
            Timestamp = DateTime.UtcNow;

            Links = new List<ERPObjectLink>(0);

            Status = ERPDocumentProcessingStatus.Unprocessed;
            TransactionNumber = Guid.Empty;
        }

        public DateTime Timestamp { get; set; }

        public List<ERPObjectLink> Links { get; set; }

        public ERPDocumentProcessingStatus Status { get; set; }
        public Guid TransactionNumber { get; set; }      
    }
}
