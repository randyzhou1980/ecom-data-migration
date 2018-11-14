using DMService.Magento.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.Magento.Repo
{
    public interface IMagentoServiceRepo
    {
        IMagentoCustomerService CustomerService { get; }
    }
}
