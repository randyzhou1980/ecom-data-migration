using DMService.Magento.Config;
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
        }
        #endregion

        public MagentoConfig Config { get; private set; }
    }
}
