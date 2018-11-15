using DMService.Magento.Config;
using Magento.RestApi;
using Magento.RestApi.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DMService.Magento.Service
{
    public class MagentoCustomerService: MagentoBaseService, IMagentoCustomerService
    {
        #region Constructor
        public MagentoCustomerService(MagentoSetting setting) : base(setting)
        {
        }
        #endregion

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            var response = await MagentoClient.GetCustomers(null);
            if (response == null || response.Result == null)
            {
                return null;
            }

            return response.Result;
        }

    }
}
