namespace DMEntity.BigCommerce
{
    public class CustomerAddress
    {
        public enum AddressType
        {
            Residential,
            Commercial
        }

        public int Id { get; set; }
        public int Customer_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }

        public string Street_1 { get; set; }
        public string Street_2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Country_iso2 { get; set; }
        public string Address_type { get; set; }
    }
}
