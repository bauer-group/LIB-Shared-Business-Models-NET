using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Free-form bag of carrier-specific configuration that does not fit the generic shipping model
    /// (currently DHL account/participation data and a custom tracking URL).
    /// </summary>
    public class ShippingCarrierSpecificData
    {
        /// <summary>Initialises a new instance with no carrier-specific data set.</summary>
        public ShippingCarrierSpecificData()
        {
            DHL = null;
            CustomTrackingURL = null;
        }

        /// <summary>
        /// DHL-specific account data: customer EKP numbers and participation (Teilnahme) codes
        /// per shipping zone (domestic, EU/Europe, world) and commodity-post variant.
        /// </summary>
        public class DHLData
        {
            /// <summary>Initialises a new instance with empty EKP numbers and default participation codes (<c>"01"</c>).</summary>
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

            /// <summary>DHL customer EKP number for domestic shipments.</summary>
            public String CustomerEKPDomestic { get; set; }
            /// <summary>DHL customer EKP number for European shipments.</summary>
            public String CustomerEKPEurope { get; set; }
            /// <summary>DHL customer EKP number for worldwide shipments.</summary>
            public String CustomerEKPWorld { get; set; }

            /// <summary>DHL participation (Teilnahme) code for domestic shipments.</summary>
            public String ParticipationDomestic { get; set; }
            /// <summary>DHL participation (Teilnahme) code for European shipments.</summary>
            public String ParticipationEurope { get; set; }
            /// <summary>DHL participation (Teilnahme) code for worldwide shipments.</summary>
            public String ParticipationWorld { get; set; }

            /// <summary>DHL customer EKP number for the domestic commodity-post (Warenpost) product.</summary>
            public String CustomerEKPCommodityPostDomestic { get; set; }
            /// <summary>DHL participation (Teilnahme) code for the domestic commodity-post (Warenpost) product.</summary>
            public String ParticipationDomesticCommodityPost { get; set; }

            /// <summary>DHL customer EKP number for the worldwide commodity-post (Warenpost) product.</summary>
            public String CustomerEKPCommodityPostWorld { get; set; }
            /// <summary>DHL participation (Teilnahme) code for the worldwide commodity-post (Warenpost) product.</summary>
            public String ParticipationWorldCommodityPost { get; set; }
        }

        /// <summary>DHL-specific account data; <c>null</c> when not applicable.</summary>
        public DHLData DHL { get; set; }

        /// <summary>Custom tracking-URL template overriding the carrier default; <c>null</c> if unset.</summary>
        public String CustomTrackingURL { get; set; }
    }
}
