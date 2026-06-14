using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPDocumentLineDeliveryType
    {
        Unknown = 0,

        Physically = 10,
        Electronic = 20,

        NotRequired = 40,

        Other = 60,

        Internal = 80
    }
}
