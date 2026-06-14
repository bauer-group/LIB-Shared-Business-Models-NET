using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPDocumentAttachmentNotFoundException : ERPDocumentException
    {
        public ERPDocumentAttachmentNotFoundException()
            : base()
        {
        }

        public ERPDocumentAttachmentNotFoundException(string sMessage)
            : base(sMessage)
        {
        }

        public ERPDocumentAttachmentNotFoundException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
        }
    }
}
