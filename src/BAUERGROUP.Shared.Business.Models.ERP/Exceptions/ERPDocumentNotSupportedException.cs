using System;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPDocumentNotSupportedException : ERPDocumentException
    {
        public ERPDocumentNotSupportedException()
            : base()
        {
        }

        public ERPDocumentNotSupportedException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPDocumentNotSupportedException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
