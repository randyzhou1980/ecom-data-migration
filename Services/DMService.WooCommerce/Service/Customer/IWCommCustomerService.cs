using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v2;

namespace DMService.WooCommerce.Service
{
    public interface IWCommCustomerService
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
    }
}
