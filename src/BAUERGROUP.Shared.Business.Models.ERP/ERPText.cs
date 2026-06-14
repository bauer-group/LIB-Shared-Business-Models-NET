using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPText : ERPObjectBase
    {
        public ERPText(String sName = @"", ERPLanguage eLanguage = null)
        {
            Language = eLanguage ?? ERPLanguage.German;
            Name = sName;
        }

        public ERPLanguage Language { get; set; }
        public String Name { get; set; }
    }
}
