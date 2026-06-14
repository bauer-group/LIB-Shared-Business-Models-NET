using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProductText : ERPText
    {
        public ERPProductText() :
            base()
        {

        }

        public ERPProductText(String sName = @"", ERPLanguage eLanguage = null)
            : base(sName, eLanguage)
        {
            Description = Notice = @"";
        }

        public String Description { get; set; }
        public String Notice { get; set; }
    }
}
