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
        private readonly IMagentoApi _client;
        public MagentoCustomerService(MagentoSetting setting) : base(setting)
        {
            _client = new MagentoApi()
                .Initialize(Config.Setting.StoreSite, Config.Setting.ConsumerKey, Config.Setting.ConsumerSecret)
                .AuthenticateAdmin(Config.Setting.UserName, Config.Setting.Password);
        }
        #endregion

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            var response = await _client.GetCustomers(null);
            if (response == null || response.Result == null)
            {
                return null;
            }

            return response.Result;
        }

    }
}
