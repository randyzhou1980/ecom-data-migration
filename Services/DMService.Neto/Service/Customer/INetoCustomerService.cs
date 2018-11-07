using DMEntity.Neto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DMService.Neto.Service
{
    public interface INetoCustomerService
    {
        Task<ICustomerResponse> AddCustomersAsync(IEnumerable<Customer> customers);
    }
}
