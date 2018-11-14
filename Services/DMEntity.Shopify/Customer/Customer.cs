using System;
using System.Collections.Generic;
using System.Text;

namespace DMEntity.Shopify
{
    public class Customer
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Phone { get; set; }
        public string Currency { get; set; }
        public string State { get; set; }
        public bool Tax_exempt { get; set; }
        public IEnumerable<CustomerAddress> Addresses { get; set; }
    }
}
