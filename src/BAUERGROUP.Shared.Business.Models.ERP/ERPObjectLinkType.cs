using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Relationship kind for an <see cref="ERPObjectLink"/> cross-object reference.
    /// </summary>
    public enum ERPObjectLinkType
    {
        /// <summary>No relationship set.</summary>
        None = 0,

        /// <summary>Forward reference (this object points to a successor).</summary>
        Forward = 10,
        /// <summary>Backward reference (this object points to a predecessor).</summary>
        Backward = 20,

        /// <summary>Reference to a peer object at the same hierarchy level.</summary>
        SameLevel = 30,
        /// <summary>Reference to a duplicate of this object.</summary>
        Duplicate = 40,

        /// <summary>Reference to an object this one depends on.</summary>
        Depending = 50
    }
}
