using Magento.RestApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DMService.Magento.Service
{
    public interface IMagentoCustomerService
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
    }
}
