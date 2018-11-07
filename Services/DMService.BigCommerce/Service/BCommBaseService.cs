using Service.Abstractions;

namespace DMService.BigCommerce.Service
{
    public class BCommBaseService: BaseService
    {
        #region Constructor
        public BCommBaseService(BigCommerceSetting setting) : base()
        {
            BCommConfig = new BigCommerceConfig(setting);

            Initialization();
        }

        public virtual void Initialization()
        {
            ApiHeaders.Add("X-Auth-Client", BCommConfig.Setting.ClientId);
            ApiHeaders.Add("X-Auth-Token", BCommConfig.Setting.AccessToken);
        }
        #endregion

        public BigCommerceConfig BCommConfig { get; private set; }
    }
}
