using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public enum FreightTermsOfTrade
    {
        [Description("EXW (Ex Works)")]
        EXW = 0,

        [Description("FCA (Free Carrier)")]
        FCA,

        [Description("FAS (Free Alongside Ship)")]
        FAS,

        [Description("FOB (Free On Board)")]
        FOB,

        [Description("CFR (Cost and Freight)")]
        CFR,

        [Description("CIF (Cost, Insurance and Freight)")]
        CIF,

        [Description("CPT (Carriage Paid To)")]
        CPT,

        [Description("CIP (Carriage and Insurance Paid To)")]
        CIP,

        [Description("DPU (Delivered at Place Unloaded)")]
        DPU,

        [Description("DAP (Delivered at Place)")]
        DAP,

        [Description("DDP (Delivered Duty Paid)")]
        DDP
    }
}
