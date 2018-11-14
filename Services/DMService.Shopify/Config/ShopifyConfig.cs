using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.Shopify.Config
{
    public class ShopifyConfig
    {
        public ShopifyConfig(ShopifySetting setting)
        {
            Setting = setting;
        }

        public ShopifySetting Setting { get; private set; }
        public string RootUrl => $"https://{Setting.StoreName}/admin/";

        #region Customer
        public class CustomerOperations
        {
            public static string GetCustomers => $"customers.json";
        }
        #endregion
    }

    public class ShopifySetting
    {
        public string ApiKey { get; set; }
        public string AccessToken { get; set; }
        public string StoreName { get; set; }
    }
}
