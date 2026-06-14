using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Bases
{
    public class ERPCodeName : ERPObjectBase
    {
        public ERPCodeName()
            : this(String.Empty, String.Empty)
        {

        }

        public ERPCodeName(String sCode, String sName)
		{
            Code = sCode;
            Name = sName;			
		}

        public String Code { get; set; }
        public String Name { get; set; }
    }
}
