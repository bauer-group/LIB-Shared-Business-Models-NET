using System;

namespace BAUERGROUP.Shared.Business.Models.Shipping
{
    /// <summary>
    /// Optional value-added service parameters for a shipment (age check, named recipient,
    /// cash-on-delivery banking, drop-off preferences and delivery scheduling).
    /// </summary>
    public class ShippingServiceParameters
    {
        /// <summary>Initialises a new instance with all parameters unset.</summary>
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

        /// <summary>Minimum recipient age required for handover, in years (<c>null</c> if no age check).</summary>
        public Byte? MinimumRequiredAge { get; set; }
        /// <summary>Recipient date of birth for age verification (<c>null</c> if not provided).</summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>Recipient first name for a named-person delivery (<c>null</c> if not set).</summary>
        public String FirstName { get; set; }
        /// <summary>Recipient last name for a named-person delivery (<c>null</c> if not set).</summary>
        public String LastName { get; set; }

        /// <summary>
        /// Bank account details into which a cash-on-delivery amount is to be remitted.
        /// </summary>
        public class CODPaymentBank
        {
            /// <summary>Initialises a new instance with all fields unset.</summary>
            public CODPaymentBank()
            {
                IBAN = null;
                BIC = null;

                BankName = null;
                AccountOwner = null;

                RemittanceInformation = null;
            }

            /// <summary>Account IBAN (<c>null</c> if not set).</summary>
            public String IBAN { get; set; }
            /// <summary>Bank BIC/SWIFT code (<c>null</c> if not set).</summary>
            public String BIC { get; set; }

            /// <summary>Name of the bank (<c>null</c> if not set).</summary>
            public String BankName { get; set; }

            /// <summary>Account holder name (<c>null</c> if not set).</summary>
            public String AccountOwner { get; set; }

            /// <summary>Remittance/payment reference text (<c>null</c> if not set).</summary>
            public String RemittanceInformation { get; set; }
        }

        /// <summary>Cash-on-delivery payout bank details (<c>null</c> if not a COD shipment).</summary>
        public CODPaymentBank PaymentBank { get; set; }

        /// <summary>Preferred drop-off location at the delivery address (<c>null</c> if not set).</summary>
        public String PreferredLocation { get; set; }
        /// <summary>Preferred neighbour for substitute delivery (<c>null</c> if not set).</summary>
        public String PreferredNeighbour { get; set; }

        /// <summary>Free-text delivery instruction for the carrier (<c>null</c> if not set).</summary>
        public String DeliveryInstruction { get; set; }

        /// <summary>Requested delivery date (<c>null</c> if no preference).</summary>
        public DateTime? PreferredDeliveryDate { get; set; }
    }
}
