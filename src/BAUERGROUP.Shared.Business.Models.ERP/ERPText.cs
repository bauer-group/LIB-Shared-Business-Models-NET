using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

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
