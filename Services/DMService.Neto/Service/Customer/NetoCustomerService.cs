using DMEntity.Neto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DMService.Neto.Service
{
    public class NetoCustomerService: NetoBaseService, INetoCustomerService
    {
        #region Constructor
        public NetoCustomerService(NetoSetting setting) : base(setting)
        {
        }
        #endregion

        public async Task<ICustomerResponse> AddCustomersAsync(IEnumerable<Customer> customers)
        {
            try
            {
                ApiHeaders.Add("NETOAPI_ACTION", NetoConfig.CustomerOperations.AddCustomer);

                var request = new CustomerRequest(customers);

                var response = await PostAsync<CustomerRequest>(NetoConfig.RootUrl, request);

                var data = await ReadResponseAsync(response);
                var result = !string.IsNullOrEmpty(data) ? JsonConvert.DeserializeObject<CustomerResponse>(data) : null;

                return result;
            }
            catch (Exception ex)
            {
                return new CustomerResponse("Error", ex.Message);
            }
        }
    }
}
