using DMService.Shopify.Config;
using Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.Shopify.Service
{
    public class ShopifyBaseService: BaseService
    {
        #region Constructor
        public ShopifyBaseService(ShopifySetting setting) : base()
        {
            ShopifyConfig = new ShopifyConfig(setting);

            Initialization();
        }

        public virtual void Initialization()
        {
            ApiHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", GetBasicAuthInfo());
        }
        #endregion

        public ShopifyConfig ShopifyConfig { get; private set; }

        private string GetBasicAuthInfo()
        {
            var authInfo = Encoding.ASCII.GetBytes($"{ShopifyConfig.Setting.ApiKey}:{ShopifyConfig.Setting.AccessToken}");

            return Convert.ToBase64String(authInfo);
        }
    }
}
