using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.Magento.Config
{
    public class MagentoConfig
    {
        public MagentoConfig(MagentoSetting setting)
        {
            Setting = setting;
        }
        public MagentoSetting Setting { get; private set; }
    }

    public class MagentoSetting
    {
        public string StoreSite { get; set; }
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
