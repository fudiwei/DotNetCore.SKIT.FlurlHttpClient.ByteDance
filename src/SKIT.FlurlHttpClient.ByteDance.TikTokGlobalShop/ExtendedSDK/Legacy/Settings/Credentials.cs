using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Settings
{
    [Obsolete("此类型专为旧版 API 设计，将于 2024-12-31 下线。")]
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="TikTokShopLegacyClientOptions.AppKey"/> 的副本。
        /// </summary>
        public string AppKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="TikTokShopLegacyClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; }

        internal Credentials(TikTokShopLegacyClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            AppKey = options.AppKey;
            AppSecret = options.AppSecret;
        }
    }
}
