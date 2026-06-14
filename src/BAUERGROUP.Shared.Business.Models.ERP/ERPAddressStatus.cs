using System;
using System.Collections.Generic;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    [Flags]
    public enum ERPAddressStatus
    {
        Active = 0,

        Disabled = 2,
        
        Obsolete = 4,
        Expired = 8,

        AdvertisingBan = 256
    }
}
