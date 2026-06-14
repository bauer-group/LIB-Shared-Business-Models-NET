using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using BAUERGROUP.Shared.Business.Models.ERP.Extensions;
using System.Globalization;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// An ISO country reference with ISO 3166 alpha-2 / alpha-3 codes and localized display names.
    /// Extends <see cref="ERPObjectBase"/> and exposes predefined static instances.
    /// </summary>
    public class ERPCountry : ERPObjectBase
    {
        /// <summary>Initialises a copy of <see cref="Germany"/> as the default country.</summary>
        public ERPCountry() :
            this(Germany)
        {

        }

        /// <summary>Initialises a country from ISO codes and a single display name in the given language.</summary>
        public ERPCountry(String sISO2, String sISO3, String sName, Boolean bEnabled = true, ERPLanguage oLanguage = null)
        {
            ISO2 = sISO2;
            ISO3 = sISO3;

            Enabled = bEnabled;

            DisplayNames = new List<ERPText>(0);
            DisplayNames.Add(new ERPText(sName, oLanguage ?? ERPLanguage.English));
        }

        /// <summary>Initialises a country from ISO codes and a list of localized display names.</summary>
        public ERPCountry(String sISO2, String sISO3, List<ERPText> oDisplayNames, Boolean bEnabled = true)
        {
            ISO2 = sISO2;
            ISO3 = sISO3;

            Enabled = bEnabled;

            DisplayNames = oDisplayNames;
        }

        /// <summary>Initialises a shallow copy of another <see cref="ERPCountry"/>.</summary>
        public ERPCountry(ERPCountry oERPCountry)
        {
            ISO2 = oERPCountry.ISO2;
            ISO3 = oERPCountry.ISO3;

            Enabled = oERPCountry.Enabled;

            DisplayNames = oERPCountry.DisplayNames;
        }

        /// <summary>ISO 3166-1 alpha-2 country code (e.g. <c>DE</c>).</summary>
        public String ISO2 { get; set; }
        /// <summary>ISO 3166-1 alpha-3 country code (e.g. <c>DEU</c>).</summary>
        public String ISO3 { get; set; }

        /// <summary>Localized display names of the country, one per language.</summary>
        public List<ERPText> DisplayNames { get; set; }

        /// <summary>Whether the country is active / selectable.</summary>
        public Boolean Enabled { get; set; }

        //Special Definitions
        /// <summary>The country derived from the current runtime region (<see cref="RegionInfo.CurrentRegion"/>).</summary>
        public readonly static ERPCountry Current = RegionInfo.CurrentRegion.FromRegionInfo();

        //Static Definitions - Primary
        /// <summary>Predefined instance for Germany.</summary>
        public readonly static ERPCountry Germany = new ERPCountry("DE", "DEU", new List<ERPText>()
        {
            new ERPText(@"Germany", ERPLanguage.English),
            new ERPText(@"Deutschland", ERPLanguage.German)
        });

        //Static Definitions - Secondary
        /// <summary>Predefined instance for the United States of America.</summary>
        public readonly static ERPCountry USA = new ERPCountry("US", "USA", new List<ERPText>()
        {
            new ERPText(@"United States of America", ERPLanguage.English),
            new ERPText(@"Vereinigte Staaten von Amerika", ERPLanguage.German)
        });

        /// <summary>Predefined instance for the People's Republic of China.</summary>
        public readonly static ERPCountry China = new ERPCountry("CN", "CHN", new List<ERPText>()
        {
            new ERPText(@"People's Republic of China", ERPLanguage.English),
            new ERPText(@"Volksrepublik China", ERPLanguage.German),
            new ERPText(@"中国", ERPLanguage.Chinese)
        });
    }
}
