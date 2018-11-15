using DMService.WooCommerce.Config;
using Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v2;

namespace DMService.WooCommerce.Service
{
    public class WCommBaseService: BaseService
    {
        #region Constructor
        public WCommBaseService(WooCommerceSetting setting) : base()
        {
            WCommConfig = new WooCommerceConfig(setting);

            Initialization();
        }

        public virtual void Initialization()
        {
            RestAPI rest = new RestAPI(WCommConfig.RootUrl, WCommConfig.Setting.ConsumerKey, WCommConfig.Setting.ConsumerSecret);
            WCommApiClient = new WCObject(rest);
        }
        #endregion

        public WCObject WCommApiClient { get; private set; }

        public WooCommerceConfig WCommConfig { get; private set; }

    }
}
