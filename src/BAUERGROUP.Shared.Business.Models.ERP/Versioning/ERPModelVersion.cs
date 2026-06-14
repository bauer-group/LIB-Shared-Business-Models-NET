using System;
using System.Reflection;

namespace BAUERGROUP.Shared.Business.Models.ERP.Versioning
{
    public static class ERPModelVersion
    {
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
