using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    public static class ERPLanguageExtensions
    {
        public static ERPLanguage FromCultureInfo(this CultureInfo oCultureInfo)
        {
            if (oCultureInfo == null)
                return null;

            return new ERPLanguage(oCultureInfo.EnglishName, oCultureInfo.TwoLetterISOLanguageName, oCultureInfo.ThreeLetterISOLanguageName);
        }        
    }
}
