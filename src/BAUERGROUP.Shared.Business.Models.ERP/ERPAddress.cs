using System;
using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    /// <summary>
    /// A postal / contact address. Extends <see cref="ERPObjectBase"/> with the legacy
    /// <c>Name1/Name2/Name3</c> recipient lines, street lines, ZIP/city, region and country,
    /// plus phone/fax/e-mail channels. Classified by <see cref="Type"/> and <see cref="Status"/>.
    /// </summary>
    public class ERPAddress: ERPObjectBase
    {
        /// <summary>Initialises a new instance with empty fields, <see cref="ERPAddressType.Unspecified"/> type and <see cref="ERPAddressStatus.Active"/> status.</summary>
        public ERPAddress()
        {
            Reference = @"";

            Salutation = Title = @"";
            Name1 = Name2 = Name3 = @"";
            Address1 = Address2 = @"";
            ZIP = City = @"";
            AdministrativeArea = @"";
            Country = @"";
            Phone = Fax = EMail = Mobile = @"";

            Type = ERPAddressType.Unspecified;
            Status = ERPAddressStatus.Active;
        }

        /// <summary>Free-text external reference for the address.</summary>
        public String Reference { get; set; }

        /// <summary>Salutation / form of address (e.g. Mr, Mrs).</summary>
        public String Salutation { get; set; }
        /// <summary>Personal or academic title (e.g. Dr, Prof).</summary>
        public String Title { get; set; }

        /// <summary>First recipient line (typically company or last name).</summary>
        public String Name1 { get; set; }
        /// <summary>Second recipient line (e.g. contact person or addendum).</summary>
        public String Name2 { get; set; }
        /// <summary>Third recipient line (e.g. department or further addendum).</summary>
        public String Name3 { get; set; }

        /// <summary>First street/address line.</summary>
        public String Address1 { get; set; }
        /// <summary>Second street/address line (suite, c/o, …).</summary>
        public String Address2 { get; set; }

        /// <summary>Postal code.</summary>
        public String ZIP { get; set; }
        /// <summary>City / town.</summary>
        public String City { get; set; }

        /// <summary>State, province or other administrative region.</summary>
        public String AdministrativeArea { get; set; }
        /// <summary>Country.</summary>
        public String Country { get; set; }

        /// <summary>E-mail address.</summary>
        public String EMail { get; set; }
        /// <summary>Landline phone number.</summary>
        public String Phone { get; set; }
        /// <summary>Mobile phone number.</summary>
        public String Mobile { get; set; }
        /// <summary>Fax number.</summary>
        public String Fax { get; set; }

        /// <summary>Functional classification of the address.</summary>
        public ERPAddressType Type { get; set; }

        /// <summary>Lifecycle status of the address.</summary>
        public ERPAddressStatus Status { get; set; }

        /// <summary>Formats the address as a multi-line block (recipient, street, ZIP/city, country and any populated contact channels).</summary>
        /// <returns>A multi-line string; empty fields are skipped.</returns>
        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();

            AppendLineIfNotEmpty(ref sb, Name1);
            AppendLineIfNotEmpty(ref sb, Name2);
            AppendLineIfNotEmpty(ref sb, Name3);

            AppendLineIfNotEmpty(ref sb, Address1);
            AppendLineIfNotEmpty(ref sb, Address2);

            sb.AppendFormat("{0}{1} {2}{0}", Environment.NewLine, ZIP, City);
            AppendLineIfNotEmpty(ref sb, Country);

            AppendLineIfNotEmpty(ref sb, Phone, "Telefon: ");
            AppendLineIfNotEmpty(ref sb, Mobile, "Mobiltelefon: ");
            AppendLineIfNotEmpty(ref sb, Fax, "Fax: ");
            AppendLineIfNotEmpty(ref sb, EMail, "E-Mail: ");

            return sb.ToString();
        }

        /// <summary>Appends <paramref name="sLine"/> (optionally prefixed) as a new line to the builder, unless the line is an empty string.</summary>
        /// <param name="oSB">The target <see cref="StringBuilder"/>.</param>
        /// <param name="sLine">The line content; nothing is appended when it equals <see cref="String.Empty"/>.</param>
        /// <param name="sPrefix">Optional prefix prepended to the line (e.g. a label).</param>
        protected void AppendLineIfNotEmpty(ref StringBuilder oSB, string sLine, string sPrefix = "")
        {
            if (sLine == string.Empty)
                return;

            oSB.AppendLine(String.Format("{0}{1}",sPrefix, sLine));
        }
    }
}

/*
 public Dictionary<PhoneType, string> PhoneNumbers { get; set; }  //Blobbed
 public Dictionary<AddressType, Address> Addresses { get; set; }  //Blobbed
 
 public enum PhoneType {
        Home,
        Work,
        Mobile,
    }

    public enum AddressType {
        Home,
        Work,
        Other,
    }
 
 public class Address {
        public String Line1 { get; set; }
        public String Line2 { get; set; }
        public String ZipCode { get; set; }
        public String State { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
    }
 */
