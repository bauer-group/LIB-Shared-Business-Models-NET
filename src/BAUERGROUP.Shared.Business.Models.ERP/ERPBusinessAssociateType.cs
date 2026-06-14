using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    [Flags]
    public enum ERPBusinessAssociateType
    {
        Other = 0,

        Customer = 2,
        Supplier = 4,

        Internal = 256
    }
}
