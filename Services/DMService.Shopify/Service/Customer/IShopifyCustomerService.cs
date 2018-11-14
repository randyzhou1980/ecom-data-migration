using DMEntity.Shopify;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DMService.Shopify.Service
{
    public interface IShopifyCustomerService
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
    }
}
