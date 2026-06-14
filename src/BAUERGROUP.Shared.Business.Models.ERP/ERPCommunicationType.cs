using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Channel through which the business communicates with a party (e.g. how documents are sent).
    /// </summary>
    public enum ERPCommunicationType
    {
        /// <summary>A channel that does not fit the predefined types.</summary>
        Other = -1,

        /// <summary>Channel not known / not recorded.</summary>
        Unkown = 0,

        Phone = 1,
        Fax = 2,

        EMail = 3,

        /// <summary>Physical postal letter.</summary>
        LetterMail = 4,

        /// <summary>Electronic commerce channel.</summary>
        eCommerce = 5,
        /// <summary>Electronic Data Interchange.</summary>
        EDI = 6,
        /// <summary>Programmatic API exchange.</summary>
        API = 7,

        /// <summary>Internal-only communication.</summary>
        Internal = 100,

        /// <summary>Automated dispatch.</summary>
        Automation = 200,
    }
}
