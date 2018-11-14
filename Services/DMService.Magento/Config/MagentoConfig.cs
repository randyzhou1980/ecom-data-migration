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
    }
}
