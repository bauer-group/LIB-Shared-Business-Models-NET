using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPEditor : ERPCodeName
    {
        public ERPEditor()
        {
            Phone = Fax = EMail = Description = @"";

            Language = ERPLanguage.German;

            CustomFields = new List<ERPCustomField>(0);
        }
        
        public String Phone { get; set; }
        public String Fax { get; set; }
        public String EMail { get; set; }
        public String Description { get; set; }

        public ERPLanguage Language { get; set; }

        public List<ERPCustomField> CustomFields { get; set; }
    }
}
