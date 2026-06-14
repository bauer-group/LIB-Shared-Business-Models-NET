using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A label / coding entry on a product (barcode, RFID, …). Extends <see cref="ERPObjectBase"/>
    /// and pairs a labeling type with its encoded code value.
    /// </summary>
    public class ERPProductLabeling : ERPObjectBase
    {
        /// <summary>Initialises a new labeling with an empty code and the default type.</summary>
        public ERPProductLabeling() :
            this(@"")
        {

        }

        /// <summary>Initialises a new labeling with the given code and type.</summary>
        /// <param name="sCode">Encoded code value.</param>
        /// <param name="eType">Labeling scheme (defaults to <see cref="ERPProductLabelingType.Unkown"/>).</param>
        public ERPProductLabeling(string sCode, ERPProductLabelingType eType = ERPProductLabelingType.Unkown)
        {
            Type = eType;
            Code = sCode;
        }

        /// <summary>Labeling scheme of the code.</summary>
        public ERPProductLabelingType Type { get; set; }
        /// <summary>Encoded code value.</summary>
        public string Code { get; set; }
    }
}
