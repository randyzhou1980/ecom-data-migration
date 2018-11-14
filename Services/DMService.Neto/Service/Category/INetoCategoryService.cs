using DMEntity.Neto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DMService.Neto.Service
{
    public interface INetoCategoryService
    {
        Task<ICategoryResponse> AddCategoriesAsync(IEnumerable<Category> categories);
    }
}
