using DMEntity.BigCommerce;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DMService.BigCommerce.Service
{
    public class BCommCustomerService: BCommBaseService, IBCommCustomerService
    {
        #region Constructor
        public BCommCustomerService(BigCommerceSetting setting) : base(setting)
        {
        }
        #endregion

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            var data = await GetStringAsync(BCommConfig.RootUrl + BigCommerceConfig.CustomerOperations.GetCustomers);

            return !string.IsNullOrWhiteSpace(data) ? JsonConvert.DeserializeObject<IEnumerable<Customer>>(data) : null;
        }

        public async Task<IEnumerable<CustomerAddress>> GetCustomerAddressesAsync(int customerId)
        {
            var data = await GetStringAsync(BCommConfig.RootUrl + BigCommerceConfig.CustomerOperations.GetCustomerAddresses(customerId));

            return string.IsNullOrEmpty(data) ? null : JsonConvert.DeserializeObject<IEnumerable<CustomerAddress>>(data);
        }

        public async Task<CustomerGroup> GetCustomerGroupByIdAsync(int groupId)
        {
            var data = await GetStringAsync(BCommConfig.RootUrl + BigCommerceConfig.CustomerOperations.GetCustomerGroup(groupId));

            return string.IsNullOrEmpty(data) ? null : JsonConvert.DeserializeObject<CustomerGroup>(data);
        }
    }
}
