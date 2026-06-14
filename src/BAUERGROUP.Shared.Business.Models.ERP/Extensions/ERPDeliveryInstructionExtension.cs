using System;
using BAUERGROUP.Shared.Business.Models.Shipping;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPDeliveryInstruction"/>.
    /// </summary>
    public static class ERPDeliveryInstructionExtension
    {
        /// <summary>Projects a shipping <see cref="Parcel"/>'s carrier and service selection onto an <see cref="ERPDeliveryInstruction"/>.</summary>
        /// <returns>A new <see cref="ERPDeliveryInstruction"/> carrying the parcel's carrier, product and service options.</returns>
        public static ERPDeliveryInstruction FromParcel(this Parcel oParcel)
        {
            return new ERPDeliveryInstruction()
            {
                Carrier = oParcel.Carrier,
                Product = oParcel.Product,
                ServiceOption = oParcel.ServiceOption,
                ServiceParameters = oParcel.ServiceParameters,
            };
        }

        /// <summary>Projects an <see cref="ERPDeliveryInstruction"/>'s carrier and service selection onto a shipping <see cref="Parcel"/>.</summary>
        /// <returns>A new <see cref="Parcel"/> carrying the instruction's carrier, product and service options.</returns>
        public static Parcel ToParcel(this ERPDeliveryInstruction oERPDeliveryInstruction)
        {
            return new Parcel()
            {
                Carrier = oERPDeliveryInstruction.Carrier,
                Product = oERPDeliveryInstruction.Product,
                ServiceOption = oERPDeliveryInstruction.ServiceOption,
                ServiceParameters = oERPDeliveryInstruction.ServiceParameters,
            };
        }
    }
}
