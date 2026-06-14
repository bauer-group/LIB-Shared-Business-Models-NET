using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProductCategory : ERPObjectBase
    {
        public ERPProductCategory()
        {
            Text = new List<ERPProductText>(1)
            {
                new ERPProductText()
            };

            Products = new List<Guid>(0);

            Subcategories = new List<Guid>(0);

            Level = 0;
            Status = ERPObjectStatus.None;

            CustomFields = new List<ERPCustomField>(0);
        }

        public List<ERPProductText> Text { get; set; }

        public String Name { get { return Text.First().Name; } set { Text.First().Name = value; } }
        public String Description { get { return Text.First().Description; } set { Text.First().Description = value; } }
        public String Notice { get { return Text.First().Notice; } set { Text.First().Notice = value; } }
        
        public List<Guid> Products { get; set; }

        public List<Guid> Subcategories { get; set; }

        public UInt16 Level { get; set; }
        public ERPObjectStatus Status { get; set; }

        public List<ERPCustomField> CustomFields { get; set; }
    }
}
