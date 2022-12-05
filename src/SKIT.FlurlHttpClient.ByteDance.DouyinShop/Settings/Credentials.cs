using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="DouyinShopClientOptions.AppKey"/> 的副本。
        /// </summary>
        public string AppKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="DouyinShopClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; }

        internal Credentials(DouyinShopClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            AppKey = options.AppKey;
            AppSecret = options.AppSecret;
        }
    }
}
