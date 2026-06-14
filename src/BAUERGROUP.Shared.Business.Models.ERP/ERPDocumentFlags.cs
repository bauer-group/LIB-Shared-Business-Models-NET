using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Free user-assignable classification flags (A–Z) on an <see cref="ERPDocument"/>.
    /// Despite the name this is a plain enumeration, not a <c>[Flags]</c> bitfield: the
    /// members carry sequential ordinals (A = 1 … Z = 26), not power-of-two bit masks,
    /// so a document holds exactly one flag value at a time. The letters have no fixed
    /// meaning and are assigned per deployment.
    /// </summary>
    public enum ERPDocumentFlags
    {
        /// <summary>No flag assigned.</summary>
        None = 0,

        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
        F = 6,
        G = 7,
        H = 8,
        I = 9,
        J = 10,
        K = 11,
        L = 12,
        M = 13,
        N = 14,        
        O = 15,
        P = 16,
        Q = 17,
        R = 18,
        S = 19,
        T = 20,
        U = 21,
        V = 22,
        W = 23,
        X = 24,
        Y = 25,
        Z = 26
    }
}
