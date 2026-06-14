using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Workflow processing state of an <see cref="ERPDocument"/>, independent of its
    /// lifecycle <c>DocumentStatus</c>.
    /// </summary>
    public enum ERPDocumentProcessingStatus
    {
        /// <summary>Not yet picked up for processing.</summary>
        Unprocessed = 0,
        Accepted = 10,
        Processing = 20,
        Complete = 30,
        Closed = 40,

        /// <summary>Processing failed.</summary>
        Error = -1
    }
}
