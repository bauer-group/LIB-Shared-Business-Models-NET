using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    public class ShippingServiceParameters
    {
        public ShippingServiceParameters()
        {
            MinimumRequiredAge = null;
            DateOfBirth = null;

            FirstName = null;
            LastName = null;

            PaymentBank = null;

            PreferredLocation = null;
            PreferredNeighbour = null;

            DeliveryInstruction = null;

            PreferredDeliveryDate = null;
        }

        public Byte? MinimumRequiredAge { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }

        public class CODPaymentBank
        {
            public CODPaymentBank()
            {
                IBAN = null;
                BIC = null;

                BankName = null;
                AccountOwner = null;

                RemittanceInformation = null;
            }

            public String IBAN { get; set; }
            public String BIC { get; set; }

            public String BankName { get; set; }

            public String AccountOwner { get; set; }

            public String RemittanceInformation { get; set; }            
        }

        public CODPaymentBank PaymentBank { get; set; }

        public String PreferredLocation { get; set; }
        public String PreferredNeighbour { get; set; }

        public String DeliveryInstruction { get; set; }

        public DateTime? PreferredDeliveryDate { get; set; }
    }
}
