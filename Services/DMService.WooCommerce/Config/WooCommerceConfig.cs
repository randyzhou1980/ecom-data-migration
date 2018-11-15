using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.WooCommerce.Config
{
    public class WooCommerceConfig
    {
        public WooCommerceConfig(WooCommerceSetting setting)
        {
            Setting = setting;
        }

        public WooCommerceSetting Setting { get; private set; }
        public string RootUrl => $"http://{Setting.StoreSite}/wp-json/wc/v2/";

        #region Customer
        public class CustomerOperations
        {
        }
        #endregion
    }

    public class WooCommerceSetting
    {
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string StoreSite { get; set; }
    }
}
