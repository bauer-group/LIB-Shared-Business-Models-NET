using System;
using System.Globalization;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    public static class ERPCountryExtensions
    {
        public static ERPCountry FromRegionInfo(this RegionInfo oRegionInfo)
        {
            if (oRegionInfo == null)
                return null;

            return new ERPCountry(oRegionInfo.TwoLetterISORegionName, oRegionInfo.ThreeLetterISORegionName, oRegionInfo.EnglishName, true, ERPLanguage.English);
        }
    }
}
