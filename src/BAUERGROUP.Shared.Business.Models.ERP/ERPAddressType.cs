using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    [Flags]
    public enum ERPAddressType
    {
        Unspecified = 0,

        Default = 1,

        Sender = 2,

        Billing = 4,
        Documents = 8,
        Shipping = 16,
        Receiver = 32,

        Forwarder = 64,

        Other = 256,

        Sales = 512,
        Marketing = 1024
    }
}
