using DMService.Magento.Config;
using Magento.RestApi;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.Magento.Service
{
    public class MagentoBaseService
    {
        #region Constructor
        public MagentoBaseService(MagentoSetting setting) : base()
        {
            Config = new MagentoConfig(setting);

            Initialization();
        }

        public virtual void Initialization()
        {
            MagentoClient = new MagentoApi()
                .Initialize(Config.Setting.StoreSite, Config.Setting.ConsumerKey, Config.Setting.ConsumerSecret)
                .AuthenticateAdmin(Config.Setting.UserName, Config.Setting.Password);

        }
        #endregion

        public IMagentoApi MagentoClient { get; private set; }

        public MagentoConfig Config { get; private set; }
    }
}
