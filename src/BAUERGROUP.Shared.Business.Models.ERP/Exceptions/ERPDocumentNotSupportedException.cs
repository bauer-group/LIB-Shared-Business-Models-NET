using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
