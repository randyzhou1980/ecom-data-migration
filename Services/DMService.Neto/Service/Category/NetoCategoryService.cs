using DMEntity.Neto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DMService.Neto.Service
{
    public class NetoCategoryService: NetoBaseService, INetoCategoryService
    {
        #region Constructor
        public NetoCategoryService(NetoSetting setting) : base(setting)
        {
        }
        #endregion

        public async Task<ICategoryResponse> AddCategoriesAsync(IEnumerable<Category> categories)
        {
            try
            {
                ApiHeaders.Add("NETOAPI_ACTION", NetoConfig.CategoryOperations.AddCategory);

                var request = new CategoryRequest(categories);

                var response = await PostAsync<CategoryRequest>(NetoConfig.RootUrl, request);

                var data = await ReadResponseAsync(response);
                var result = !string.IsNullOrEmpty(data) ? JsonConvert.DeserializeObject<CategoryResponse>(data) : null;

                return result;
            }
            catch (Exception ex)
            {
                return new CategoryResponse("Error", ex.Message);
            }
        }
    }
}
