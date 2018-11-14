using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magento.DM.API.Model
{
    public class MagentoResponse
    {
        public bool Status { get; set; }
        public int TotalProcessed { get; set; }
        public int Succeed { get; set; }
        public int Failed => TotalProcessed - Succeed;
        public IEnumerable<string> Errors { get; set; }

    }
}
