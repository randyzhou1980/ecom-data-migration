using DMService.Magento.Config;
using Magento.RestApi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DMService.Magento.Service
{
    public class MagentoCustomerService: MagentoBaseService, IMagentoCustomerService
    {
        #region Constructor
        private readonly IMagentoApi _client;
        public MagentoCustomerService(MagentoSetting setting) : base(setting)
        {
            _client = new MagentoApi()
                .Initialize("http://www.hugh-magento.com/index.php", "akr7ydkkvq5m94xvins4c1jtc8reh1zm", "rvmy3on3get6dpl0wf4zzd3snd3my93o")
                .AuthenticateAdmin("admin", "hugh123456");
        }
        #endregion

        public async Task GetCustomersAsync()
        {
        }

    }
}
