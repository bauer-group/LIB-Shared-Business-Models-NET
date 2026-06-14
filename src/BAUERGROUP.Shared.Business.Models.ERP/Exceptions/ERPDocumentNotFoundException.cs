using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPDocumentNotFoundException : ERPDocumentException
    {
        public ERPDocumentNotFoundException()
            : base()
        {
        }

        public ERPDocumentNotFoundException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPDocumentNotFoundException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
