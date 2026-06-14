using BAUERGROUP.Shared.Business.Models.ERP.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.ERP
{
    public class ERPAddress: ERPObjectBase
    {
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

        public String Reference { get; set; }

        public String Salutation { get; set; }
        public String Title { get; set; }

        public String Name1 { get; set; }
        public String Name2 { get; set; }
        public String Name3 { get; set; }

        public String Address1 { get; set; }
        public String Address2 { get; set; }

        public String ZIP { get; set; }
        public String City { get; set; }

        public String AdministrativeArea { get; set; }
        public String Country { get; set; }

        public String EMail { get; set; }
        public String Phone { get; set; }
        public String Mobile { get; set; }        
        public String Fax { get; set; }

        public ERPAddressType Type { get; set; }

        public ERPAddressStatus Status { get; set; }

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
