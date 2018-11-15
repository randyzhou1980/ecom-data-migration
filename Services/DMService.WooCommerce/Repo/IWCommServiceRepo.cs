using DMService.WooCommerce.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.WooCommerce.Repo
{
    public interface IWCommServiceRepo
    {
        IWCommCustomerService CustomerService { get; }

    }
}
