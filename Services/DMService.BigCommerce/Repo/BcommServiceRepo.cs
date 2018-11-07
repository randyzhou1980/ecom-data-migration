using DMService.BigCommerce.Service;
using Microsoft.Extensions.Options;

namespace DMService.BigCommerce.Repo
{
    public class BcommServiceRepo: IBCommServiceRepo
    {
        #region Constructor
        private readonly BigCommerceSetting _settings;
        public BcommServiceRepo(IOptionsSnapshot<BigCommerceSetting> config)
        {
            _settings = config.Value;
        }
        #endregion
        public IBCommCustomerService CustomerService => new BCommCustomerService(_settings);
    }
}
