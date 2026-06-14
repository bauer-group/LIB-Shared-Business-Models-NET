using System;
using System.Reflection;

namespace BAUERGROUP.Shared.Business.Models.ERP.Versioning
{
    /// <summary>
    /// Exposes the ERP model/schema version, derived from the executing assembly version.
    /// </summary>
    public static class ERPModelVersion
    {
        /// <summary>
        /// Model version encoded as <c>(Major * 1000) + Minor</c> (e.g. version 1.2 yields <c>1002</c>).
        /// <c>Minor</c> is therefore capped at 999.
        /// </summary>
        public static UInt32 Version
        {
            get
            {
                var vAssembly = Assembly.GetExecutingAssembly().GetName().Version;

                //Major = n000; Minor = nXXX; Minor can be max. 999; Example Version 1.2 == 1002
                return (UInt32)((vAssembly.Major * 1000) + vAssembly.Minor);
            }
        }
    }
}
