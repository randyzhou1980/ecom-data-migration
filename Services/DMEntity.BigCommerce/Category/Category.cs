using System;
using System.Collections.Generic;
using System.Text;

namespace DMEntity.BigCommerce
{
    public class Category
    {
        public int Id { get; set; }
        public int Parent_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Sort_order { get; set; }
        public bool Is_visible { get; set; }
    }
}
