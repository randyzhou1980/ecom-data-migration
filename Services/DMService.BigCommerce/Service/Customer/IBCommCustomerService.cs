using DMEntity.BigCommerce;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DMService.BigCommerce.Service
{
    public interface IBCommCustomerService
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task<IEnumerable<CustomerAddress>> GetCustomerAddressesAsync(int customerId);
        Task<CustomerGroup> GetCustomerGroupByIdAsync(int groupId);
    }
}
