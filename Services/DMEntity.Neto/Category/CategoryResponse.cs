using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMEntity.Neto
{
    public class CategoryResponse: ApiBaseResponse, ICategoryResponse
    {
        public CategoryResponse(string ack, string msg) : base()
        {
            Ack = ack;
            Messages = new ReponseMessage();

            var error = new List<ReponseMsg>();
            error.Add(new ReponseMsg() { Message = msg });
            Messages.Error = error;
        }

        public object Category { get; set; }

        public IEnumerable<int> CategoryIDs
        {
            get
            {
                var categories = GetCategories();
                return categories?.Select(c => c.CategoryID);
            }
        }

        private IEnumerable<CategoryResponseInfo> GetCategories()
        {
            if (Category == null || string.IsNullOrWhiteSpace(Category.ToString()))
            {
                return null;
            }

            var categoryInfo = new List<CategoryResponseInfo>();

            if (Category.GetType().Name == "JArray")
            {
                categoryInfo.AddRange(JsonConvert.DeserializeObject<IEnumerable<CategoryResponseInfo>>(Category.ToString()));
            }
            else
            {
                categoryInfo.Add(JsonConvert.DeserializeObject<CategoryResponseInfo>(Category.ToString()));
            }
            return categoryInfo;
        }

        public class CategoryResponseInfo
        {
            public int CategoryID { get; set; }
        }
    }
}
