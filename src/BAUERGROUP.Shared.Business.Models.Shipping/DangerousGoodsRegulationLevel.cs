using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// ADR/IATA dangerous-goods regulation level. Values ascend by regulatory strictness, so
    /// <c>Max()</c> over several contents yields the strictest applicable level.
    /// </summary>
    // Werte aufsteigend nach Regulierungsstrenge — Max() liefert die strengste Stufe.
    public enum DangerousGoodsRegulationLevel
    {
        /// <summary>Not dangerous goods / no regulation applies.</summary>
        None = 0,

        /// <summary>Excepted quantities (EQ) — exempt amounts.</summary>
        Excepted = 1,        // EQ, freigestellte Mengen
        /// <summary>Limited quantities (LQ) — limited amounts per package.</summary>
        LimitedQuantity = 2, // LQ, begrenzte Mengen je Versandstück
        /// <summary>Fully regulated dangerous goods — declared in full per ADR/IATA.</summary>
        Full = 3,            // Voll-Gefahrgut, ADR/IATA vollständig deklariert
    }
}
