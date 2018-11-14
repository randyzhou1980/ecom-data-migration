using System;
using System.Collections.Generic;
using System.Text;

namespace DMEntity.Shopify
{
    public class CustomerAddress
    {
        public string Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string Country_code { get; set; }
        public string Customer_id { get; set; }
        public bool Default { get; set; }
        public string Phone { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }
    }
}
