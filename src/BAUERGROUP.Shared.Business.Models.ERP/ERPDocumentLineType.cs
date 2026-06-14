using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public enum ERPDocumentLineType
    {
        ArticleMasterProduct = 0,

        Product = 1,
        Ancillary = 2,
        BOM = 3,

        Text = 100,
        Comment = 101,

        Subtotal = 200
    }
}
