using DMEntity.Shopify;
using DMService.Shopify.Config;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DMService.Shopify.Service
{
    public class ShopifyCustomerService: ShopifyBaseService, IShopifyCustomerService
    {
        #region Constructor
        public ShopifyCustomerService(ShopifySetting setting) : base(setting)
        {
        }
        #endregion

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            var data = await GetStringAsync(ShopifyConfig.RootUrl + ShopifyConfig.CustomerOperations.GetCustomers);

            if (string.IsNullOrWhiteSpace(data))
            {
                return null;
            }

            var result = JObject.Parse(data);

            return JsonConvert.DeserializeObject<IEnumerable<Customer>>(result["customers"].ToString());
        }
    }
}
