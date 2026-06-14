using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Classification of a document attached to an <see cref="ERPBusinessAssociate"/>.
    /// </summary>
    public enum ERPBusinessAssociateAttachmentType
    {
        /// <summary>A document that does not fit the predefined categories (default).</summary>
        Other = 0,

        /// <summary>General correspondence.</summary>
        Correspondence = 10,

        /// <summary>A contract.</summary>
        Contract = 50,
        /// <summary>A contract termination / cancellation.</summary>
        Termination = 51,

        /// <summary>A statement (e.g. account statement).</summary>
        Statement = 100,

        /// <summary>Informational document.</summary>
        Information = 200
    }
}
