using System;
using System.Text;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// A sender or receiver address on a parcel, with name lines, street, location and contact channels.
    /// </summary>
    public class ParcelAddress
    {
        /// <summary>Initialises a new instance with all fields set to empty strings.</summary>
        public ParcelAddress()
        {
            Reference = @"";

            Name1 = Name2 = Name3 = @"";
            Address1 = Address2 = @"";
            ZIP = City = @"";
            Country = @"";
            Phone = EMail = Fax = @"";
        }

        /// <summary>Free-text reference for the address.</summary>
        public string Reference { get; set; }

        /// <summary>First name line (company or person).</summary>
        public string Name1 { get; set; }
        /// <summary>Second name line.</summary>
        public string Name2 { get; set; }
        /// <summary>Third name line.</summary>
        public string Name3 { get; set; }

        /// <summary>First street/address line.</summary>
        public string Address1 { get; set; }
        /// <summary>Second street/address line.</summary>
        public string Address2 { get; set; }

        /// <summary>Postal code.</summary>
        public string ZIP { get; set; }
        /// <summary>City.</summary>
        public string City { get; set; }

        /// <summary>Country.</summary>
        public string Country { get; set; }

        /// <summary>Phone number.</summary>
        public string Phone { get; set; }
        /// <summary>E-mail address.</summary>
        public string EMail { get; set; }
        /// <summary>Fax number.</summary>
        public string Fax { get; set; }

        /// <summary>Renders the full address followed by phone, fax and e-mail lines.</summary>
        /// <returns>A multi-line string of the address and its contact channels.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}{1}{1}", ToFullAddress(true), Environment.NewLine);

            AppendLineIfNotEmpty(ref sb, Phone, "Telefon: ");
            AppendLineIfNotEmpty(ref sb, Fax, "Telefax: ");
            AppendLineIfNotEmpty(ref sb, EMail, "E-Mail: ");

            return sb.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }

        /// <summary>Renders the name, street and location lines as a single address block.</summary>
        /// <param name="bWithCountry">When <c>true</c>, appends the country line.</param>
        /// <returns>A multi-line string of the postal address.</returns>
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

        /// <summary>Appends <paramref name="sLine"/> (optionally prefixed) to <paramref name="oSB"/> unless it is empty.</summary>
        /// <param name="oSB">The buffer to append to.</param>
        /// <param name="sLine">The line content; ignored when empty.</param>
        /// <param name="sPrefix">Optional prefix written before the line.</param>
        protected void AppendLineIfNotEmpty(ref StringBuilder oSB, string sLine, string sPrefix = "")
        {
            if (sLine == string.Empty)
                return;

            oSB.AppendLine(String.Format("{0}{1}", sPrefix, sLine));
        }
    }
}
