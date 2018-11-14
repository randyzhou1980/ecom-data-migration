using System;
using System.Collections.Generic;
using System.Text;

namespace DMEntity.Neto
{
    public class CategoryRequest
    {
        public CategoryRequest(IEnumerable<Category> categories)
        {
            Category = categories;
        }

        public IEnumerable<Category> Category { get; set; }
    }
}
