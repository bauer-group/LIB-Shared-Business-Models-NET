using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPCustomField : ERPCodeName
    {
        public ERPCustomField() :
            this(@"", @"", @"")
        {
                      
        }

        public ERPCustomField(String sCode, String sValue) :
            this(sCode, @"", sValue)
        {
            
        }

        public ERPCustomField(String sCode, String sName, String sValue)
        {
            Code = sCode;
            Name = sName;
            Value = sValue;
        }

        public String Value { get; set; }

        public ERPCustomField(String sCode, Int32 iValue) :
            this(sCode, iValue.ToString())
        {

        }

        public ERPCustomField(String sCode, String sName, Int32 iValue) :
            this(sCode, sName, iValue.ToString())
        {
            
        }
    }
}
