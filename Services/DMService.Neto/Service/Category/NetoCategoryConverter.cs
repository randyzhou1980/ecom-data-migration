using DMEntity.Neto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMService.Neto.Service
{
    public class NetoCategoryConverter: INetoCategoryConverter
    {
        #region BigCommerce
        public IEnumerable<Category> ConvertToCategory(IEnumerable<DMEntity.BigCommerce.Category> bcommCategories)
        {
            if (bcommCategories == null || bcommCategories.Count() == 0)
            {
                return null;
            }

            return bcommCategories.Select(bc => new Category()
            {
                CategoryID = bc.Id,
                ParentCategoryID = bc.Parent_id,
                CategoryName = bc.Name,
                Description1 = bc.Description,
                SortOrder = bc.Sort_order,
                Active = bc.Is_visible,
                ShortDescription3 = bc.Id.ToString(),
                Description3 = $"BigCommerce Category ID {bc.Id}"
            })
            .OrderBy(c => c.ParentCategoryID)
            .ThenBy(c => c.CategoryID);
        }
        #endregion

    }
}
