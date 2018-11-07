using System.Collections.Generic;

namespace DMEntity.Neto
{
    public class CustomerRequest
    {
        public CustomerRequest(IEnumerable<Customer> customers)
        {
            Customer = customers;
        }

        public IEnumerable<Customer> Customer { get; set; }
    }
}
