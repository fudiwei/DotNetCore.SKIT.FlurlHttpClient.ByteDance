using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="TikTokV2ClientOptions.ClientKey"/> 的副本。
        /// </summary>
        public string ClientKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="TikTokV2ClientOptions.ClientSecret"/> 的副本。
        /// </summary>
        public string ClientSecret { get; }

        internal Credentials(TikTokV2ClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            ClientKey = options.ClientKey;
            ClientSecret = options.ClientSecret;
        }
    }
}
