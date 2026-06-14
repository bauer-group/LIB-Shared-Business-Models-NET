using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using BAUERGROUP.Shared.Business.Models.ERP.Extensions;
using System.Globalization;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPCountry : ERPObjectBase
    {
        public ERPCountry() :
            this(Germany)
        {
            
        }

        public ERPCountry(String sISO2, String sISO3, String sName, Boolean bEnabled = true, ERPLanguage oLanguage = null)
        {
            ISO2 = sISO2;
            ISO3 = sISO3;

            Enabled = bEnabled;

            DisplayNames = new List<ERPText>(0);
            DisplayNames.Add(new ERPText(sName, oLanguage ?? ERPLanguage.English));
        }

        public ERPCountry(String sISO2, String sISO3, List<ERPText> oDisplayNames, Boolean bEnabled = true)
        {
            ISO2 = sISO2;
            ISO3 = sISO3;

            Enabled = bEnabled;

            DisplayNames = oDisplayNames;
        }

        public ERPCountry(ERPCountry oERPCountry)
        {
            ISO2 = oERPCountry.ISO2;
            ISO3 = oERPCountry.ISO3;

            Enabled = oERPCountry.Enabled;

            DisplayNames = oERPCountry.DisplayNames;
        }

        public String ISO2 { get; set; }
        public String ISO3 { get; set; }

        public List<ERPText> DisplayNames { get; set; }

        public Boolean Enabled { get; set; }

        //Special Definitions        
        public readonly static ERPCountry Current = RegionInfo.CurrentRegion.FromRegionInfo();

        //Static Definitions - Primary
        public readonly static ERPCountry Germany = new ERPCountry("DE", "DEU", new List<ERPText>()
        {
            new ERPText(@"Germany", ERPLanguage.English),
            new ERPText(@"Deutschland", ERPLanguage.German)
        });

        //Static Definitions - Secondary
        public readonly static ERPCountry USA = new ERPCountry("US", "USA", new List<ERPText>()
        {
            new ERPText(@"United States of America", ERPLanguage.English),
            new ERPText(@"Vereinigte Staaten von Amerika", ERPLanguage.German)
        });

        public readonly static ERPCountry China = new ERPCountry("CN", "CHN", new List<ERPText>()
        {
            new ERPText(@"People's Republic of China", ERPLanguage.English),
            new ERPText(@"Volksrepublik China", ERPLanguage.German),
            new ERPText(@"中国", ERPLanguage.Chinese)
        });
    }
}
