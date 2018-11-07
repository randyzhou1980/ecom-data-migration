using System;

namespace DMService.Neto
{
    public class NetoConfig
    {
        public NetoConfig(NetoSetting setting)
        {
            Setting = setting;
        }
        public NetoSetting Setting { get; private set; }

        public string RootUrl => $"https://{Setting.SiteUrl}/do/WS/NetoAPI";

        // Customer
        public class CustomerOperations
        {
            public static string AddCustomer => $"AddCustomer";
        }
    }

    public class NetoSetting
    {
        public string ApiKey { get; set; }
        public string SiteUrl { get; set; }
    }
}
