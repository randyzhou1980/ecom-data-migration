using DMService.WooCommerce.Config;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v2;

namespace DMService.WooCommerce.Service
{
    public class WCommCustomerService: WCommBaseService, IWCommCustomerService
    {
        #region Constructor
        public WCommCustomerService(WooCommerceSetting setting) : base(setting)
        {
        }
        #endregion

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            var data = await WCommApiClient.Customer.GetAll();
            return null;
        }
    }
}
