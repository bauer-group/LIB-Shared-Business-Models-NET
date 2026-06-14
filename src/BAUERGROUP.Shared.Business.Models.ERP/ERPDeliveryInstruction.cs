using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using BAUERGROUP.Shared.Business.Models.Shipping;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPDeliveryInstruction : ERPObjectBase
    {
        public ERPDeliveryInstruction()
            : this(FreightCarriers.DHL_BusinessClientShipping)
        {
            
        }

        public ERPDeliveryInstruction(FreightCarriers oCarrier, FreightCarrierProducts oProduct = FreightCarrierProducts.Default, List<FreightCarrierServices> oServiceOptions = null, ShippingServiceParameters oServiceParameters = null)
        {
            Carrier = oCarrier;
            Product = oProduct;
            ServiceOption = oServiceOptions ?? new List<FreightCarrierServices>(0);
            ServiceParameters = oServiceParameters;
        }

        public FreightCarriers Carrier { get; set; }
        public FreightCarrierProducts Product { get; set; }
        public List<FreightCarrierServices> ServiceOption { get; set; }
        public ShippingServiceParameters ServiceParameters { get; set; }
    }
}
