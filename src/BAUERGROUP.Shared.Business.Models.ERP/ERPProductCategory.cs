using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A product category in the classification hierarchy. Extends <see cref="ERPObjectBase"/>
    /// and groups products and nested subcategories with localized texts.
    /// </summary>
    public class ERPProductCategory : ERPObjectBase
    {
        /// <summary>Initialises a new category at level 0 with one empty localized text block.</summary>
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

        /// <summary>Localized text blocks (name, description, notice per language).</summary>
        public List<ERPProductText> Text { get; set; }

        /// <summary>Name of the first localized <see cref="ERPProductText"/> block.</summary>
        public String Name { get { return Text.First().Name; } set { Text.First().Name = value; } }
        /// <summary>Description of the first localized <see cref="ERPProductText"/> block.</summary>
        public String Description { get { return Text.First().Description; } set { Text.First().Description = value; } }
        /// <summary>Notice of the first localized <see cref="ERPProductText"/> block.</summary>
        public String Notice { get { return Text.First().Notice; } set { Text.First().Notice = value; } }

        /// <summary>Identifiers of the products assigned to this category.</summary>
        public List<Guid> Products { get; set; }

        /// <summary>Identifiers of the nested child categories.</summary>
        public List<Guid> Subcategories { get; set; }

        /// <summary>Depth of the category within the hierarchy (root = <c>0</c>).</summary>
        public UInt16 Level { get; set; }
        /// <summary>Lifecycle status of the category record.</summary>
        public ERPObjectStatus Status { get; set; }

        /// <summary>User-defined custom fields.</summary>
        public List<ERPCustomField> CustomFields { get; set; }
    }
}
