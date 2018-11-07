using System;

namespace DMEntity.Neto
{
    public class Customer
    {
        public string Username { get; set; }
        public string Type { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string SecondaryEmailAddress { get; set; }
        public bool NewsletterSubscriber { get; set; }
        public string ParentUsername { get; set; }
        public string ApprovalUsername { get; set; }
        public string ReferralUsername { get; set; }
        //public decimal? ReferralCommission { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentificationType { get; set; }
        public string IdentificationDetails { get; set; }
        //public decimal? DefaultDiscounts { get; set; }
        public string InternalNotes { get; set; }
        public string ABN { get; set; }
        public string WebsiteURL { get; set; }
        public decimal CreditLimit { get; set; }
        public string DefaultInvoiceTerms { get; set; }
        public string Classification1 { get; set; }
        public string Classification2 { get; set; }
        public string SalesChannel { get; set; }
        public bool Active { get; set; }
        public bool OnCreditHold { get; set; }
        public string UserGroup { get; set; }
        public AccountManager AccountManager { get; set; }
        public string DefaultOrderType { get; set; }

        public BillingAddress BillingAddress { get; set; }
        public ShippingAddress ShippingAddress { get; set; }

        public Customer(string userName)
        {
            Username = userName;

            Type = "Customer";
            Active = true;
            Password = "P@ssw0rd123";
        }
    }

}
