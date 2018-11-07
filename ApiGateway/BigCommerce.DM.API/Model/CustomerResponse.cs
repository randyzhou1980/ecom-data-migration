using System.Collections.Generic;

namespace BigCommerce.DM.API.Model
{
    public class CustomerResponse
    {
        public bool Status { get; set; }
        public int TotalProcessed { get; set; }
        public int Succeed { get; set; }
        public int Failed => TotalProcessed - Succeed;
        public IEnumerable<string> Errors { get; set; }

    }
}
