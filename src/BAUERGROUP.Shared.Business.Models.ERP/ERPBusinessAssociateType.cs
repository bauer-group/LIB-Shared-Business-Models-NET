using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Classification of an <see cref="ERPBusinessAssociate"/> (a party may hold several roles).
    /// Bitwise-combinable (<see cref="FlagsAttribute"/>).
    /// </summary>
    [Flags]
    public enum ERPBusinessAssociateType
    {
        /// <summary>A party that does not fit the predefined types (default).</summary>
        Other = 0,

        /// <summary>A customer.</summary>
        Customer = 2,
        /// <summary>A supplier / vendor.</summary>
        Supplier = 4,

        /// <summary>An internal party (e.g. an own company / branch).</summary>
        Internal = 256
    }
}
