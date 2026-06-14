using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Category of a file attached to a product.
    /// </summary>
    public enum ERPProductAttachmentType
    {
        /// <summary>A file that does not fit the predefined categories.</summary>
        Other = 0,

        Datasheet = 10,
        SafetyDatasheet = 20,
        Brochure = 30,
        UserManual = 40,
        MaintenanceManual = 50
    }
}
