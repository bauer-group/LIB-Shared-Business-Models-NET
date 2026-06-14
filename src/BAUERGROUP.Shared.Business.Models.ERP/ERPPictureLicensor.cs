using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Category of party from which the license/attribution of an <see cref="ERPPicture"/> originates.
    /// </summary>
    public enum ERPPictureLicensor
    {
        /// <summary>Image produced in-house; no external license required.</summary>
        OwnCreation = -1,

        Supplier = 10,
        Manufacturer = 20,
        Importer = 30,

        /// <summary>Licensed from a party outside the supply chain.</summary>
        ThirdParty = 50
    }
}
