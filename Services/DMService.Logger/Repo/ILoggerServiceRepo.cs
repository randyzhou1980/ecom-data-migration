using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.Logger.Repo
{
    public interface ILoggerServiceRepo
    {
        ILogger Logger { get; }
    }
}
