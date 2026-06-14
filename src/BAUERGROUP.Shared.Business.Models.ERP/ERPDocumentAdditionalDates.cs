using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPDocumentAdditionalDates : ERPObjectBase
    {
        public ERPDocumentAdditionalDates()
        {
            Type = ERPDateType.Unkown;
            Date = DateTime.UtcNow;
        }

        public ERPDocumentAdditionalDates(ERPDateType eType, DateTime dtDate)
        {
            Type = eType;
            Date = dtDate;
        }

        public ERPDateType Type { get; set; }
        public DateTime Date { get; set; }
    }
}
