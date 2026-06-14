using System;
using System.Globalization;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPLanguage"/>.
    /// </summary>
    public static class ERPLanguageExtensions
    {
        /// <summary>Builds an <see cref="ERPLanguage"/> from a .NET <see cref="CultureInfo"/>, using its English name and ISO language codes.</summary>
        /// <param name="oCultureInfo">The culture to convert.</param>
        /// <returns>A new <see cref="ERPLanguage"/>, or <c>null</c> if <paramref name="oCultureInfo"/> is <c>null</c>.</returns>
        public static ERPLanguage FromCultureInfo(this CultureInfo oCultureInfo)
        {
            if (oCultureInfo == null)
                return null;

            return new ERPLanguage(oCultureInfo.EnglishName, oCultureInfo.TwoLetterISOLanguageName, oCultureInfo.ThreeLetterISOLanguageName);
        }        
    }
}
