using System;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    [Flags]
    public enum ERPShippingInstruction
    {
        //Shipping Instruction
        None = 0,
        Internal = 1,
        
        Standard = 2,
        Express = 4,
        Cargo = 8,

        TwoManHandling = 64,

        WillCollect = 128,

        External = 256,

        //Insurance Option yes/no
        Insured = 16,
        Uninsured = 32
    }
}

//Other free Values = 192, 256, 512 ,1024, 2048, 4096, 8192, 16384, 32768, ..., All = 2147483647
