using System;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class ParcelAddress
    {
        public ParcelAddress()
        {
            Reference = @"";

            Name1 = Name2 = Name3 = @"";
            Address1 = Address2 = @"";
            ZIP = City = @"";
            Country = @"";
            Phone = EMail = Fax = @"";
        }

        public string Reference { get; set; }

        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public string ZIP { get; set; }
        public string City { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }
        public string EMail { get; set; }
        public string Fax { get; set; } 

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}{1}{1}", ToFullAddress(true), Environment.NewLine);

            AppendLineIfNotEmpty(ref sb, Phone, "Telefon: ");
            AppendLineIfNotEmpty(ref sb, Fax, "Telefax: ");
            AppendLineIfNotEmpty(ref sb, EMail, "E-Mail: ");

            return sb.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }

        public string ToFullAddress(bool bWithCountry = true)
        {
            StringBuilder sb = new StringBuilder();

            AppendLineIfNotEmpty(ref sb, Name1);
            AppendLineIfNotEmpty(ref sb, Name2);
            AppendLineIfNotEmpty(ref sb, Name3);

            AppendLineIfNotEmpty(ref sb, Address1);
            AppendLineIfNotEmpty(ref sb, Address2);

            sb.AppendFormat("{0}{1} {2}{0}", Environment.NewLine, ZIP, City);
            
            if (bWithCountry)
                AppendLineIfNotEmpty(ref sb, Country);

            return sb.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }

        protected void AppendLineIfNotEmpty(ref StringBuilder oSB, string sLine, string sPrefix = "")
        {
            if (sLine == string.Empty)
                return;

            oSB.AppendLine(String.Format("{0}{1}", sPrefix, sLine));
        }
    }
}
