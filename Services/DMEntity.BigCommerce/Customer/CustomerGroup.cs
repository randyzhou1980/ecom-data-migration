using System.Collections.Generic;

namespace DMEntity.BigCommerce
{
    public class CustomerGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Is_default { get; set; }
        public object Category_access { get; set; }
        public IEnumerable<object> Discount_rules { get; set; }
    }
}
