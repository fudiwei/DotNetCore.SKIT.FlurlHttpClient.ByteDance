using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="DouyinOpenClientOptions.ClientKey"/> 的副本。
        /// </summary>
        public string ClientKey { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="DouyinOpenClientOptions.ClientSecret"/> 的副本。
        /// </summary>
        public string ClientSecret { get; }

        internal Credentials(DouyinOpenClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            ClientKey = options.ClientKey;
            ClientSecret = options.ClientSecret;
        }
    }
}
