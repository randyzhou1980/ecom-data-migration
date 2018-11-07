using Service.Abstractions;

namespace DMService.Neto.Service
{
    public class NetoBaseService: BaseService
    {
        #region Constructor
        public NetoBaseService(NetoSetting setting) : base()
        {
            NetoConfig = new NetoConfig(setting);

            Initialization();
        }

        public virtual void Initialization()
        {
            ApiHeaders.Add("NETOAPI_KEY", NetoConfig.Setting.ApiKey);
        }
        #endregion

        public NetoConfig NetoConfig { get; private set; }
    }
}
