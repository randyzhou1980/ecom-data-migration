using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DMEntity.Neto
{
    public class ApiBaseResponse: IApiResponse
    {
        public ApiBaseResponse()
        {
            CurrentTime = new DateTime();
        }

        public DateTime CurrentTime { get; set; }
        public string Ack { get; set; }
        public ReponseMessage Messages { get; set; }


        public string Status => Ack;
        public IEnumerable<string> Errors
        {
            get
            {
                var errors = GetErrors();
                return errors?.Select(e => e.Message);
            }
        }

        private IEnumerable<ReponseMsg> GetErrors()
        {
            if (Messages == null || Messages.Error == null || string.IsNullOrWhiteSpace(Messages.Error.ToString()))
            {
                return null;
            }

            var errors = new List<ReponseMsg>();

            if (Messages.Error.GetType().Name == "JArray")
            {
                errors.AddRange(JsonConvert.DeserializeObject<IEnumerable<ReponseMsg>>(Messages.Error.ToString()));
            }
            else
            {
                errors.Add(JsonConvert.DeserializeObject<ReponseMsg>(Messages.Error.ToString()));
            }

            return errors;
        }

        public class ReponseMessage
        {
            public object Error { get; set; }
            public object Warning { get; set; }
        }

        public class ReponseMsg
        {
            public string Message { get; set; }
            public string SeverityCode { get; set; }
        }
    }
}
