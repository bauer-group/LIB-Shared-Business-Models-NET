using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPDocumentException : ERPException
    {
        public ERPDocumentException()
            : base()
        {
        }

        public ERPDocumentException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPDocumentException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
