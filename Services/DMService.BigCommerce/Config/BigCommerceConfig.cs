using System;

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

        #region Customer
        public class CustomerOperations
        {
            public static string GetCustomers => $"v2/customers";
            public static string GetCustomerAddresses(int customerId) => $"v2/customers/{customerId}/addresses";
            public static string GetCustomerGroup(int groupId) => $"v2/customer_groups/{groupId}";
        }
        #endregion

        #region Catalog
        public class CatalogOperations
        {
            public static string GetCategories => $"v3/catalog/categories";
            public static string GetProducts => $"v3/catalog/products";
            public static string GetProductBrand(int brandId) => $"v3/catalog/brands/{brandId}";
            public static string GetProductImages(int productId) => $"v3/catalog/products/{productId}/images";
            public static string GetProductVariants(int productId) => $"v3/catalog/products/{productId}/variants";
        }
        #endregion
    }

    public class BigCommerceSetting
    {
        public string ClientId { get; set; }
        public string AccessToken { get; set; }
        public string StoreId { get; set; }
    }
}
