using DMService.WooCommerce.Config;
using DMService.WooCommerce.Service;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.WooCommerce.Repo
{
    public class WCommServiceRepo: IWCommServiceRepo
    {
        #region Constructor
        private readonly WooCommerceSetting _settings;
        public WCommServiceRepo(IOptionsSnapshot<WooCommerceSetting> config)
        {
            _settings = config.Value;
        }
        #endregion
        public IWCommCustomerService CustomerService => new WCommCustomerService(_settings);

    }
}
