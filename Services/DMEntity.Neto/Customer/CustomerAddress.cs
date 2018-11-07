namespace DMEntity.Neto
{
    public class BillingAddress
    {
        public string BillFirstName { get; set; }
        public string BillLastName { get; set; }
        public string BillCompany { get; set; }
        public string BillStreetLine1 { get; set; }
        public string BillStreetLine2 { get; set; }
        public string BillCity { get; set; }
        public string BillState { get; set; }
        public string BillPostCode { get; set; }
        public string BillCountry { get; set; }
        public string BillPhone { get; set; }
        public string BillFax { get; set; }
    }

    public class ShippingAddress
    {
        public string ShipTitle { get; set; }
        public string ShipFirstName { get; set; }
        public string ShipLastName { get; set; }
        public string ShipCompany { get; set; }
        public string ShipStreetLine1 { get; set; }
        public string ShipStreetLine2 { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string ShipPostCode { get; set; }
        public string ShipCountry { get; set; }
        public string ShipPhone { get; set; }
        public string ShipFax { get; set; }
    }
}
