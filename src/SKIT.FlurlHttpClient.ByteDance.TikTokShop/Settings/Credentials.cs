using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="TikTokShopClientOptions.AppKey"/> 的副本。
        /// </summary>
        public string AppKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="TikTokShopClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; }

        internal Credentials(TikTokShopClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            AppKey = options.AppKey;
            AppSecret = options.AppSecret;
        }
    }
}
