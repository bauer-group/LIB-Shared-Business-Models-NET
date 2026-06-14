using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPProduct : ERPObjectBase
    {
        public ERPProduct()
        {
            Reference = @"";

            Unit = @"";

            Weight = new ERPWeight();
            Volume = new ERPVolume();
            Dimensions = new ERPDimensions();

            IdentificationTypes = new List<ERPProductLOTSerialType>(0);
            
            CustomFields = new List<ERPCustomField>(0);

            Links = new List<ERPProductLink>(0);

            Prices = new List<ERPProductPrices>(0);

            VAT = 0m;

            Pictures = new List<ERPProductPicture>(0);

            Text = new List<ERPProductText>(1)
            {
                new ERPProductText()
            };

            Labeling = new List<ERPProductLabeling>(0);

            Extensions = new ERPProductExtensions();

            Attachments = new List<ERPProductAttachment>(0);

			Attributes = new List<ERPProductAttribute>(0);

            Customs = new List<ERPCustoms>(0);

            Suppliers = new List<ERPProductSupplier>(0);

            Manufacturer = new ERPProductManufacturer();

            Brand = new List<ERPProductBrand>(0);

            Status = ERPObjectStatus.None;
        }

        public String Reference { get; set; }

        //Sales Unit
        public String Unit { get; set; }
        
        public ERPWeight Weight { get; set; }
        public ERPVolume Volume { get; set; }
        public ERPDimensions Dimensions { get; set; }

        public String Name { get { return Text.First().Name; } set { Text.First().Name = value; } }
        public String Description { get { return Text.First().Description; } set { Text.First().Description = value; } }

        public String Notice { get { return Text.First().Notice; } set { Text.First().Notice = value; } }

        [Obsolete]
        public Decimal VAT { get; set; }

        public List<ERPProductLOTSerialType> IdentificationTypes { get; set; }
        
        public List<ERPCustomField> CustomFields { get; set; }

        public List<ERPProductLink> Links { get; set; }

        public List<ERPProductPrices> Prices { get; set; }

        public List<ERPProductPicture> Pictures { get; set; }

        public List<ERPProductText> Text { get; set; }

        //Sales Unit
        public List<ERPProductLabeling> Labeling { get; set; }

        //Special Purposes
        public ERPProductExtensions Extensions { get; set; }

        public List<ERPProductAttachment> Attachments { get; set; }

		public List<ERPProductAttribute> Attributes { get; set; }

        public List<ERPCustoms> Customs { get; set; }

        public List<ERPProductSupplier> Suppliers { get; set; }

        public ERPProductManufacturer Manufacturer { get; set; }

        public List<ERPProductBrand> Brand { get; set; }

        public ERPObjectStatus Status { get; set; }
    }
}
