using DMService.Shopify.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.Shopify.Repo
{
    public interface IShopifyServiceRepo
    {
        IShopifyCustomerService CustomerService { get; }
    }
}
