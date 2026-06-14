using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPDocumentProcessingStatus
    {
        Unprocessed = 0,
        Accepted = 10,
        Processing = 20,
        Complete = 30,
        Closed = 40,

        Error = -1
    }
}
