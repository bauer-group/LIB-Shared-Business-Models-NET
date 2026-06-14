using BAUERGROUP.Shared.Business.Models.Shipping;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    public static class ERPDeliveryInstructionExtension
    {
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
