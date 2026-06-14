using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Exceptions
{
    public class ERPProductNotFoundException : ERPProductException
    {
        public ERPProductNotFoundException()
            : base()
        {
            Reference = @"";
        }

        public ERPProductNotFoundException(string sMessage)
            : base(sMessage)
        {
            Reference = @"";
        }

        public ERPProductNotFoundException(string sMessage, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
            Reference = @"";
        }

        public String Reference { get; set; }

        public ERPProductNotFoundException(string sMessage, string sReference)
            : base(sMessage)
        {
            Reference = sReference;
        }

        public ERPProductNotFoundException(string sMessage, string sReference, Exception eInnerException)
            : base(sMessage, eInnerException)
        {
            Reference = sReference;
        }
    }
}
