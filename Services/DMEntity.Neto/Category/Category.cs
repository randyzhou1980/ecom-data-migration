using System;
using System.Collections.Generic;
using System.Text;

namespace DMEntity.Neto
{
    public class Category
    {
        public int CategoryID { get; set; }
        public int ParentCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description1 { get; set; }
        public int SortOrder { get; set; }
        public bool Active { get; set; }

        public string ShortDescription3 { get; set; }
        public string Description3 { get; set; }
    }
}
