using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A typed date entry attached to an <see cref="ERPDocument"/> beyond its standard
    /// order/document/shipping dates. Extends <see cref="ERPObjectBase"/>.
    /// </summary>
    public class ERPDocumentAdditionalDates : ERPObjectBase
    {
        /// <summary>Initialises a new instance with an unknown type and the current UTC date.</summary>
        public ERPDocumentAdditionalDates()
        {
            Type = ERPDateType.Unkown;
            Date = DateTime.UtcNow;
        }

        /// <summary>Initialises a new instance with the specified date type and value.</summary>
        /// <param name="eType">The kind of date this entry represents.</param>
        /// <param name="dtDate">The date value.</param>
        public ERPDocumentAdditionalDates(ERPDateType eType, DateTime dtDate)
        {
            Type = eType;
            Date = dtDate;
        }

        /// <summary>Kind of date this entry represents.</summary>
        public ERPDateType Type { get; set; }
        /// <summary>The date value.</summary>
        public DateTime Date { get; set; }
    }
}
