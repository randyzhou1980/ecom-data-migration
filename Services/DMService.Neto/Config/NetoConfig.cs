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

        #region Customer
        public class CustomerOperations
        {
            public static string AddCustomer => $"AddCustomer";
        }
        #endregion

        #region Category
        public class CategoryOperations
        {
            public static string AddCategory => $"AddCategory";
        }
        #endregion
    }

    public class NetoSetting
    {
        public string ApiKey { get; set; }
        public string SiteUrl { get; set; }
    }
}
