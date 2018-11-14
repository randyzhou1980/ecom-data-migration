using DMEntity.Neto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.Neto.Service
{
    public interface INetoCategoryConverter
    {
        IEnumerable<Category> ConvertToCategory(IEnumerable<DMEntity.BigCommerce.Category> bcommCategories);
    }
}
