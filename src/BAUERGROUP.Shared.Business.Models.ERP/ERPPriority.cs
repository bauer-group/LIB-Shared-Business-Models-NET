using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Priority ranking for ERP tasks and reminders, ordered from <see cref="VeryLow"/> to <see cref="Critical"/>.
    /// </summary>
    public enum ERPPriority
    {
        VeryLow = -2,
        Low = -1,

        /// <summary>Default, mid-range priority.</summary>
        Normal = 0,

        High = 1,
        VeryHigh = 2,

        Critical = 3
    }
}
