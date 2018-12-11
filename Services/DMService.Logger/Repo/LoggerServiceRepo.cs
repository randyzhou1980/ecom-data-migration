using DMService.Logger.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.Logger.Repo
{
    public class LoggerServiceRepo: ILoggerServiceRepo
    {
        #region Constructor
        private readonly LoggerConfig _settings;
        public LoggerServiceRepo(IOptionsSnapshot<LoggerConfig> config)
        {
            _settings = config.Value;

            InitLogger();
        }

        private void InitLogger()
        {
            switch (_settings.LogDB.Name)
            {
                case "MSSqlServer":
                    Log.Logger = new LoggerConfiguration()
                        .WriteTo.MSSqlServer(_settings.LogDB.ConnectionString, _settings.LogDB.TableName, _settings.LogEventLevel, autoCreateSqlTable: true)
                        .CreateLogger();
                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Properties
        public ILogger Logger => Log.Logger;
        #endregion


    }
}
