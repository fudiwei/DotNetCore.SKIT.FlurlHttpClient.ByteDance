using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="TikTokClientOptions.ClientKey"/> 或 <see cref="TikTokClientOptionsV2.ClientKey"/> 的副本。
        /// </summary>
        public string ClientKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="TikTokClientOptions.ClientSecret"/> 或 <see cref="TikTokClientOptionsV2.ClientKey"/> 的副本。
        /// </summary>
        public string ClientSecret { get; }

        internal Credentials(TikTokClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            ClientKey = options.ClientKey;
            ClientSecret = options.ClientSecret;
        }

        internal Credentials(TikTokClientOptionsV2 options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            ClientKey = options.ClientKey;
            ClientSecret = options.ClientSecret;
        }
    }
}
