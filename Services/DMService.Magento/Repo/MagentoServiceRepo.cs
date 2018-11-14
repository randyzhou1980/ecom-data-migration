using DMService.Magento.Config;
using DMService.Magento.Service;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.Magento.Repo
{
    public class MagentoServiceRepo: IMagentoServiceRepo
    {
        #region Constructor
        private readonly MagentoSetting _settings;
        public MagentoServiceRepo(IOptionsSnapshot<MagentoSetting> config)
        {
            _settings = config.Value;
        }
        #endregion
        public IMagentoCustomerService CustomerService => new MagentoCustomerService(_settings);

    }
}
