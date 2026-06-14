using System;
using BAUERGROUP.Shared.Business.Models.Shipping;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPBusinessAssociate"/>.
    /// </summary>
    public static class ERPBusinessAssociateExtensions
    {
        /// <summary>Projects an <see cref="ERPBusinessAssociate"/> onto a shipping <see cref="ParcelAddress"/> via its inherited address surface.</summary>
        /// <returns>A new <see cref="ParcelAddress"/> populated from the associate's address.</returns>
        public static ParcelAddress FromERPBusinessAssociate(this ERPBusinessAssociate erpBusinessAssociate)
        {
            return erpBusinessAssociate.FromERPAddress();
        }

        /// <summary>Projects a shipping <see cref="ParcelAddress"/> onto an <see cref="ERPBusinessAssociate"/>.</summary>
        /// <returns>The address materialised as an <see cref="ERPBusinessAssociate"/>, or <c>null</c> if the produced <see cref="ERPAddress"/> is not one.</returns>
        public static ERPBusinessAssociate ToERPBusinessAssociate(this ParcelAddress parcelAddress)
        {
            var oERPAddress = parcelAddress.ToERPAddress();
            return (oERPAddress as ERPBusinessAssociate);
        }

        /// <summary>Trims whitespace from every public string property of the business associate, in place.</summary>
        public static void Trim(this ERPBusinessAssociate erpBusinessAssociate)
        {
            erpBusinessAssociate.TrimPublicStringProperties();
        }

        /// <summary>Copies the address fields from a shipping <see cref="ParcelAddress"/> into an existing <see cref="ERPBusinessAssociate"/>, in place.</summary>
        /// <param name="erpBusinessAssociate">The target business associate to update.</param>
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
