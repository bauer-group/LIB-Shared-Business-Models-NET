using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using BAUERGROUP.Shared.Business.Models.Shipping;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Coded delivery / shipping handling instruction. Extends <see cref="ERPObjectBase"/> and
    /// selects a carrier, product and the requested service options for the shipment.
    /// </summary>
    public class ERPDeliveryInstruction : ERPObjectBase
    {
        /// <summary>Initialises a new instruction defaulting to <see cref="FreightCarriers.DHL_BusinessClientShipping"/>.</summary>
        public ERPDeliveryInstruction()
            : this(FreightCarriers.DHL_BusinessClientShipping)
        {

        }

        /// <summary>Initialises a new instruction with the given carrier, product, service options and parameters.</summary>
        /// <param name="oCarrier">Freight carrier to use.</param>
        /// <param name="oProduct">Carrier product; defaults to <see cref="FreightCarrierProducts.Default"/>.</param>
        /// <param name="oServiceOptions">Requested service options; an empty list is used when <c>null</c>.</param>
        /// <param name="oServiceParameters">Optional additional service parameters.</param>
        public ERPDeliveryInstruction(FreightCarriers oCarrier, FreightCarrierProducts oProduct = FreightCarrierProducts.Default, List<FreightCarrierServices> oServiceOptions = null, ShippingServiceParameters oServiceParameters = null)
        {
            Carrier = oCarrier;
            Product = oProduct;
            ServiceOption = oServiceOptions ?? new List<FreightCarrierServices>(0);
            ServiceParameters = oServiceParameters;
        }

        /// <summary>Freight carrier handling the shipment.</summary>
        public FreightCarriers Carrier { get; set; }
        /// <summary>Carrier product selected for the shipment.</summary>
        public FreightCarrierProducts Product { get; set; }
        /// <summary>Requested carrier service options.</summary>
        public List<FreightCarrierServices> ServiceOption { get; set; }
        /// <summary>Additional service parameters for the carrier (may be <c>null</c>).</summary>
        public ShippingServiceParameters ServiceParameters { get; set; }
    }
}
