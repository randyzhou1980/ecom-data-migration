using DMService.Shopify.Config;
using DMService.Shopify.Service;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.Shopify.Repo
{
    public class ShopifyServiceRepo: IShopifyServiceRepo
    {
        #region Constructor
        private readonly ShopifySetting _settings;
        public ShopifyServiceRepo(IOptionsSnapshot<ShopifySetting> config)
        {
            _settings = config.Value;
        }
        #endregion
        public IShopifyCustomerService CustomerService => new ShopifyCustomerService(_settings);
    }
}
