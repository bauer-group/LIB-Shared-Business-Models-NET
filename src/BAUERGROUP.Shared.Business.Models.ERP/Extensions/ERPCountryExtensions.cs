using System;
using System.Globalization;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPCountry"/>.
    /// </summary>
    public static class ERPCountryExtensions
    {
        /// <summary>Builds an <see cref="ERPCountry"/> from a .NET <see cref="RegionInfo"/>, using its ISO codes and English name.</summary>
        /// <param name="oRegionInfo">The region to convert.</param>
        /// <returns>A new <see cref="ERPCountry"/>, or <c>null</c> if <paramref name="oRegionInfo"/> is <c>null</c>.</returns>
        public static ERPCountry FromRegionInfo(this RegionInfo oRegionInfo)
        {
            if (oRegionInfo == null)
                return null;

            return new ERPCountry(oRegionInfo.TwoLetterISORegionName, oRegionInfo.ThreeLetterISORegionName, oRegionInfo.EnglishName, true, ERPLanguage.English);
        }
    }
}
