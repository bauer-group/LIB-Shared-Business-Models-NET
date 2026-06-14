using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPSalesChannel : ERPCodeName
    {
        public ERPSalesChannel() :
            this(String.Empty, String.Empty, String.Empty)
        {
            
        }

        public ERPSalesChannel(String sCode) :
            this(sCode, String.Empty, String.Empty)
        {

        }

        public ERPSalesChannel(String sCode, String sName) :
            this(sCode, sName, String.Empty)
        {

        }

        public ERPSalesChannel(String sCode, String sName, String sReference) :
            base(sCode, sName)
        {
            Reference = sReference;
            CustomFields = new List<ERPCustomField>(0);
        }

        public String Reference { get; set; }

        public List<ERPCustomField> CustomFields { get; set; }
    }
}
