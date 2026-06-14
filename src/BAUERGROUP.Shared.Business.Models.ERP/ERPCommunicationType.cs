using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPCommunicationType
    {
        Other = -1,

        Unkown = 0,

        Phone = 1,
        Fax = 2,

        EMail = 3,

        LetterMail = 4,

        eCommerce = 5,
        EDI = 6,
        API = 7,

        Internal = 100,

        Automation = 200,
    }
}
