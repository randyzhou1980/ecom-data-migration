using DMEntity.BigCommerce;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DMService.BigCommerce.Service
{
    public interface IBCommProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Brand> GetProductBrandAsync(int brandId);
        Task<IEnumerable<ProductImage>> GetProductImagesAsync(int productId);
    }
}
