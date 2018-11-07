using DMService.Neto.Service;
using Microsoft.Extensions.Options;

namespace DMService.Neto.Repo
{
    public class NetoServiceRepo: INetoServiceRepo
    {
        #region Constructor
        private readonly NetoSetting _settings;
        public NetoServiceRepo(IOptionsSnapshot<NetoSetting> config)
        {
            _settings = config.Value;
        }
        #endregion
        public INetoCustomerConverter CustomerConverter => new NetoCustomerConverter();
        public INetoCustomerService CustomerService => new NetoCustomerService(_settings);
    }
}
