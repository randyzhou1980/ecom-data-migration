using DMEntity.BigCommerce;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMService.BigCommerce.Service
{
    public class BCommCategoryService: BCommBaseService, IBCommCategoryService
    {
        #region Constructor
        public BCommCategoryService(BigCommerceSetting setting) : base(setting)
        {
        }
        #endregion

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            var data = await GetStringAsync(BCommConfig.RootUrl + BigCommerceConfig.CatalogOperations.GetCategories);
            if (string.IsNullOrWhiteSpace(data))
            {
                return null;
            }

            var result = JObject.Parse(data);

            return JsonConvert.DeserializeObject<IEnumerable<Category>>(result["data"].ToString());
        }

        public async Task<IEnumerable<Category>> GetCategoriesByIdsAsync(IEnumerable<int> categoryIds)
        {
            if (categoryIds == null || categoryIds.Count() == 0)
            {
                return null;
            }

            var categories = await GetCategoriesAsync();
            if (categories == null)
            {
                return null;
            }


            return categories.Where(c => categoryIds.Any(id => id == c.Id));
        }
    }
}
