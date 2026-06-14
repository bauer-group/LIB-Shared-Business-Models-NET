using System;
using BAUERGROUP.Shared.Business.Models.Shipping;
using BAUERGROUP.Shared.Core.Extensions;

namespace BAUERGROUP.Shared.Business.Models.ERP.Extensions
{
    /// <summary>
    /// Extension helpers for <see cref="ERPAddress"/>.
    /// </summary>
    public static class ERPAddressExtensions
    {
        /// <summary>Trims whitespace from every public string property of the address, in place.</summary>
        public static void Trim(this ERPAddress erpAddress)
        {
            erpAddress.TrimPublicStringProperties();
        }

        /// <summary>Projects an <see cref="ERPAddress"/> onto a shipping <see cref="ParcelAddress"/>.</summary>
        /// <returns>A new <see cref="ParcelAddress"/> populated from the source address, with its string properties trimmed.</returns>
        public static ParcelAddress FromERPAddress(this ERPAddress erpAddress)
        {
            ParcelAddress pa = new ParcelAddress();

            pa.Reference = erpAddress.Reference;

            pa.Name1 = erpAddress.Name1;
            pa.Name2 = erpAddress.Name2;
            pa.Name3 = erpAddress.Name3;

            pa.Address1 = erpAddress.Address1;
            pa.Address2 = erpAddress.Address2;
            
            pa.ZIP = erpAddress.ZIP;            
            pa.City = erpAddress.City;
            pa.Country = erpAddress.Country;
            
            pa.EMail = erpAddress.EMail;
            pa.Fax = erpAddress.Fax;
            pa.Phone = erpAddress.Phone;

            pa.TrimPublicStringProperties();

            return pa;
        }

        /// <summary>Projects a shipping <see cref="ParcelAddress"/> onto an <see cref="ERPAddress"/>.</summary>
        /// <returns>A new <see cref="ERPAddress"/> populated from the source address, with its string properties trimmed.</returns>
        public static ERPAddress ToERPAddress(this ParcelAddress parcelAddress)
        {
            ERPAddress ea = new ERPAddress();

            ea.Reference = parcelAddress.Reference;

            ea.Name1 = parcelAddress.Name1;
            ea.Name2 = parcelAddress.Name2;
            ea.Name3 = parcelAddress.Name3;

            ea.Address1 = parcelAddress.Address1;
            ea.Address2 = parcelAddress.Address2;

            ea.ZIP = parcelAddress.ZIP;
            ea.City = parcelAddress.City;
            ea.Country = parcelAddress.Country;

            ea.EMail = parcelAddress.EMail;
            ea.Fax = parcelAddress.Fax;
            ea.Phone = parcelAddress.Phone;

            ea.TrimPublicStringProperties();

            return ea;
        }

        /// <summary>Copies the address fields from a shipping <see cref="ParcelAddress"/> into an existing <see cref="ERPAddress"/>, in place.</summary>
        /// <param name="erpAddress">The target address to update.</param>
        public static void UpdateERPAddress(this ParcelAddress parcelAddress, ref ERPAddress erpAddress)
        {
            erpAddress.Reference = parcelAddress.Reference;

            erpAddress.Name1 = parcelAddress.Name1;
            erpAddress.Name2 = parcelAddress.Name2;
            erpAddress.Name3 = parcelAddress.Name3;

            erpAddress.Address1 = parcelAddress.Address1;
            erpAddress.Address2 = parcelAddress.Address2;

            erpAddress.ZIP = parcelAddress.ZIP;
            erpAddress.City = parcelAddress.City;
            erpAddress.Country = parcelAddress.Country;

            erpAddress.EMail = parcelAddress.EMail;
            erpAddress.Fax = parcelAddress.Fax;
            erpAddress.Phone = parcelAddress.Phone;            
        }
    }
}
