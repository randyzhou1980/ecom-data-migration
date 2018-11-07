using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace DMEntity.Neto
{
    public class CustomerResponse : ApiBaseResponse, ICustomerResponse
    {
        public CustomerResponse(string ack, string msg): base()
        {
            Ack = ack;
            Messages = new ReponseMessage();

            var error = new List<ReponseMsg>();
            error.Add(new ReponseMsg() { Message = msg });
            Messages.Error = error;
        }

        public object Customer { get; set; }

        public IEnumerable<string> UserNames
        {
            get
            {
                var users = GetUsers();
                return users?.Select(u => u.Username);
            }
        }

        private IEnumerable<CustomerResponseInfo> GetUsers()
        {
            if (Customer == null || string.IsNullOrWhiteSpace(Customer.ToString()))
            {
                return null;
            }

            var customerInfo = new List<CustomerResponseInfo>();

            if (Customer.GetType().Name == "JArray")
            {
                customerInfo.AddRange(JsonConvert.DeserializeObject<IEnumerable<CustomerResponseInfo>>(Customer.ToString()));
            }
            else
            {
                customerInfo.Add(JsonConvert.DeserializeObject<CustomerResponseInfo>(Customer.ToString()));
            }
            return customerInfo;
        }

        public class CustomerResponseInfo
        {
            public string Username { get; set; }
        }
    }
}
