using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

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
