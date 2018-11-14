using DMEntity.BigCommerce;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DMService.BigCommerce.Service
{
    public interface IBCommCategoryService
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<IEnumerable<Category>> GetCategoriesByIdsAsync(IEnumerable<int> categoryIds);
    }
}
