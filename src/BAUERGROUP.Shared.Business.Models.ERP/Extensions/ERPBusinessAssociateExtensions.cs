using BAUERGROUP.Shared.Business.Models.Shipping;
using BAUERGROUP.Shared.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    public static class ERPBusinessAssociateExtensions
    {
        public static ParcelAddress FromERPBusinessAssociate(this ERPBusinessAssociate erpBusinessAssociate)
        {
            return erpBusinessAssociate.FromERPAddress();
        }

        public static ERPBusinessAssociate ToERPBusinessAssociate(this ParcelAddress parcelAddress)
        {
            var oERPAddress = parcelAddress.ToERPAddress();
            return (oERPAddress as ERPBusinessAssociate);
        }

        public static void Trim(this ERPBusinessAssociate erpBusinessAssociate)
        {
            erpBusinessAssociate.TrimPublicStringProperties();
        }

        public static void UpdateERPBusinessAssociate(this ParcelAddress parcelAddress, ref ERPBusinessAssociate erpBusinessAssociate)
        {
            erpBusinessAssociate.Reference = parcelAddress.Reference;

            erpBusinessAssociate.Name1 = parcelAddress.Name1;
            erpBusinessAssociate.Name2 = parcelAddress.Name2;
            erpBusinessAssociate.Name3 = parcelAddress.Name3;

            erpBusinessAssociate.Address1 = parcelAddress.Address1;
            erpBusinessAssociate.Address2 = parcelAddress.Address2;

            erpBusinessAssociate.ZIP = parcelAddress.ZIP;
            erpBusinessAssociate.City = parcelAddress.City;
            erpBusinessAssociate.Country = parcelAddress.Country;

            erpBusinessAssociate.EMail = parcelAddress.EMail;
            erpBusinessAssociate.Fax = parcelAddress.Fax;
            erpBusinessAssociate.Phone = parcelAddress.Phone;
        }
    }
}
