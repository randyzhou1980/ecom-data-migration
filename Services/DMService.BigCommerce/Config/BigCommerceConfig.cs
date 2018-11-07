﻿using System;

namespace DMService.BigCommerce
{
    public class BigCommerceConfig
    {
        public BigCommerceConfig(BigCommerceSetting setting)
        {
            Setting = setting;
        }

        public BigCommerceSetting Setting { get; private set; }
        public string RootUrl => $"https://api.bigcommerce.com/stores/{Setting.StoreId}/";

        // Customer
        public class CustomerOperations
        {
            public static string GetCustomers => $"v2/customers";
            public static string GetCustomerAddresses(int customerId) => $"v2/customers/{customerId}/addresses";
            public static string GetCustomerGroup(int groupId) => $"v2/customer_groups/{groupId}";
        }

    }

    public class BigCommerceSetting
    {
        public string ClientId { get; set; }
        public string AccessToken { get; set; }
        public string StoreId { get; set; }
    }
}
