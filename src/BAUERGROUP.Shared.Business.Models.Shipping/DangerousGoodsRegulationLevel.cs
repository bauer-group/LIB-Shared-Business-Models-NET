using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    // Werte aufsteigend nach Regulierungsstrenge — Max() liefert die strengste Stufe.
    public enum DangerousGoodsRegulationLevel
    {
        None = 0,

        Excepted = 1,        // EQ, freigestellte Mengen
        LimitedQuantity = 2, // LQ, begrenzte Mengen je Versandstück
        Full = 3,            // Voll-Gefahrgut, ADR/IATA vollständig deklariert
    }
}
