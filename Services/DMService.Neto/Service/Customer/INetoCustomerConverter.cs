using DMEntity.Neto;
using System.Collections.Generic;

namespace DMService.Neto.Service
{
    public interface INetoCustomerConverter
    {
        Customer ConvertToCustomer(DMEntity.BigCommerce.Customer bcommCustomer);
        IEnumerable<Customer> ConvertToCustomers(IEnumerable<DMEntity.Shopify.Customer> shopifyCustomers);
    }
}
