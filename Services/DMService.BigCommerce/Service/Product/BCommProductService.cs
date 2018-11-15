using DMEntity.BigCommerce;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DMService.BigCommerce.Service
{
    public class BCommProductService: BCommBaseService, IBCommProductService
    {
        #region Constructor
        public BCommProductService(BigCommerceSetting setting) : base(setting)
        {
        }
        #endregion

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var data = await GetStringAsync(BCommConfig.RootUrl + BigCommerceConfig.CatalogOperations.GetProducts);
            if (string.IsNullOrWhiteSpace(data))
            {
                return null;
            }

            var result = JObject.Parse(data);

            return JsonConvert.DeserializeObject<IEnumerable<Product>>(result["data"].ToString());
        }

        public async Task<ProductBrand> GetProductBrandAsync(int brandId)
        {
            var data = await GetStringAsync(BCommConfig.RootUrl + BigCommerceConfig.CatalogOperations.GetProductBrand(brandId));
            if (string.IsNullOrWhiteSpace(data))
            {
                return null;
            }

            var result = JObject.Parse(data);

            return JsonConvert.DeserializeObject<ProductBrand>(result["data"].ToString());
        }

        public async Task<IEnumerable<ProductImage>> GetProductImagesAsync(int productId)
        {
            var data = await GetStringAsync(BCommConfig.RootUrl + BigCommerceConfig.CatalogOperations.GetProductImages(productId));
            if (string.IsNullOrWhiteSpace(data))
            {
                return null;
            }

            var result = JObject.Parse(data);

            return JsonConvert.DeserializeObject<IEnumerable<ProductImage>>(JObject.Parse(data)["data"].ToString());
        }

        public async Task<IEnumerable<Product>> GetProductVariantByProductIdAsync(int productId)
        {
            var data = await GetStringAsync(BCommConfig.RootUrl + BigCommerceConfig.CatalogOperations.GetProductVariants(productId));
            if (string.IsNullOrWhiteSpace(data))
            {
                return null;
            }

            var result = JObject.Parse(data);

            return JsonConvert.DeserializeObject<IEnumerable<Product>>(result["data"].ToString());
        }
    }
}
