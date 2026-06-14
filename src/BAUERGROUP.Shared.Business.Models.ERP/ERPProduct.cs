using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// Article / item master record of the ERP product domain. Extends <see cref="ERPObjectBase"/>
    /// and aggregates the full product surface — identification, sales unit, physical attributes,
    /// localized texts, prices, pictures, labeling, attachments, specifications, suppliers,
    /// manufacturer and brands.
    /// </summary>
    public class ERPProduct : ERPObjectBase
    {
        /// <summary>Initialises a new product with neutral defaults and one empty localized text block.</summary>
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

        /// <summary>Free-text product reference (e.g. article number).</summary>
        public String Reference { get; set; }

        //Sales Unit
        /// <summary>Sales unit of measure the product is sold in.</summary>
        public String Unit { get; set; }

        /// <summary>Product weight.</summary>
        public ERPWeight Weight { get; set; }
        /// <summary>Product volume.</summary>
        public ERPVolume Volume { get; set; }
        /// <summary>Product dimensions.</summary>
        public ERPDimensions Dimensions { get; set; }

        /// <summary>Name of the first localized <see cref="ERPProductText"/> block.</summary>
        public String Name { get { return Text.First().Name; } set { Text.First().Name = value; } }
        /// <summary>Description of the first localized <see cref="ERPProductText"/> block.</summary>
        public String Description { get { return Text.First().Description; } set { Text.First().Description = value; } }

        /// <summary>Notice of the first localized <see cref="ERPProductText"/> block.</summary>
        public String Notice { get { return Text.First().Notice; } set { Text.First().Notice = value; } }

        /// <summary>Value-added tax rate. Deprecated — VAT now lives on the price records.</summary>
        [Obsolete]
        public Decimal VAT { get; set; }

        /// <summary>LOT / serial-number identification schemes that apply to the product.</summary>
        public List<ERPProductLOTSerialType> IdentificationTypes { get; set; }

        /// <summary>User-defined custom fields.</summary>
        public List<ERPCustomField> CustomFields { get; set; }

        /// <summary>Loose links to related products.</summary>
        public List<ERPProductLink> Links { get; set; }

        /// <summary>Price records for the product.</summary>
        public List<ERPProductPrices> Prices { get; set; }

        /// <summary>Product pictures.</summary>
        public List<ERPProductPicture> Pictures { get; set; }

        /// <summary>Localized text blocks (name, description, notice per language).</summary>
        public List<ERPProductText> Text { get; set; }

        //Sales Unit
        /// <summary>Labels / coding schemes (barcode, RFID, …) attached to the product.</summary>
        public List<ERPProductLabeling> Labeling { get; set; }

        //Special Purposes
        /// <summary>Special-purpose extension data for the product.</summary>
        public ERPProductExtensions Extensions { get; set; }

        /// <summary>Attached files (datasheets, manuals, …).</summary>
        public List<ERPProductAttachment> Attachments { get; set; }

		/// <summary>Key/value specification attributes.</summary>
		public List<ERPProductAttribute> Attributes { get; set; }

        /// <summary>Customs / tariff classification entries.</summary>
        public List<ERPCustoms> Customs { get; set; }

        /// <summary>Suppliers that offer the product.</summary>
        public List<ERPProductSupplier> Suppliers { get; set; }

        /// <summary>Manufacturer of the product.</summary>
        public ERPProductManufacturer Manufacturer { get; set; }

        /// <summary>Brands associated with the product.</summary>
        public List<ERPProductBrand> Brand { get; set; }

        /// <summary>Lifecycle status of the product record.</summary>
        public ERPObjectStatus Status { get; set; }
    }
}
