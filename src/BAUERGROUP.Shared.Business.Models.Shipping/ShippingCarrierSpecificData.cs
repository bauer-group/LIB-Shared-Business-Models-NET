using System;
using System.Collections.Generic;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class ShippingCarrierSpecificData
    {
        public ShippingCarrierSpecificData()
        {
            DHL = null;
            CustomTrackingURL = null;
        }

        public class DHLData
        {
            public DHLData()
            {
                CustomerEKPDomestic = @"";
                CustomerEKPEurope = @"";
                CustomerEKPWorld = @"";

                ParticipationDomestic = "01";
                ParticipationEurope = "01";
                ParticipationWorld = "01";

                CustomerEKPCommodityPostDomestic = @"";
                ParticipationDomesticCommodityPost = "01";

                CustomerEKPCommodityPostWorld = @"";
                ParticipationWorldCommodityPost = "01";
            }

            public String CustomerEKPDomestic { get; set; }
            public String CustomerEKPEurope { get; set; }
            public String CustomerEKPWorld { get; set; }

            public String ParticipationDomestic { get; set; }
            public String ParticipationEurope { get; set; }
            public String ParticipationWorld { get; set; }

            public String CustomerEKPCommodityPostDomestic { get; set; }
            public String ParticipationDomesticCommodityPost { get; set; }

            public String CustomerEKPCommodityPostWorld { get; set; }
            public String ParticipationWorldCommodityPost { get; set; }
        }

        public DHLData DHL { get; set; }

        public String CustomTrackingURL { get; set; }
    }
}
