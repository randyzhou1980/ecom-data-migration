using System;
using System.Collections.Generic;

namespace DMEntity.BigCommerce
{
    public class Customer
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Date_created { get; set; }
        public DateTime Date_modified { get; set; }
        public decimal Store_credit { get; set; }
        public string Registration_ip_address { get; set; }
        public int Customer_group_id { get; set; }
        public string Notes { get; set; }
        public string Tax_exempt_category { get; set; }
        public bool Accepts_marketing { get; set; }

        public IEnumerable<CustomerAddress> CustomerAddresses { get; set; }
        public CustomerGroup CustomerGroups { get; set; }

        public Customer()
        {
        }

        private string _userName;
        public string UserName
        {
            get
            {
                if (string.IsNullOrEmpty(_userName))
                {
                    _userName = ($"bc_{Id}_{DateTime.Now.Ticks}").Substring(0, 15);
                }

                return _userName;
            }
        }
    }
}
