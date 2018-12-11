using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.Logger.Config
{
    public class LoggerConfig
    {
        public string MinimumLevel { get; set; }
        public LogEventLevel LogEventLevel => (LogEventLevel)Enum.Parse(typeof(LogEventLevel), MinimumLevel);

        public LogDBDetails LogDB { get; set; }

        public class LogDBDetails
        {
            public string Name { get; set; }
            public string ConnectionString { get; set; }
            public string TableName { get; set; }
        }
    }
}
