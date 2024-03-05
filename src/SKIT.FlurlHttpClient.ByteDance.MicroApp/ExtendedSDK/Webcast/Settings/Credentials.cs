using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppWebcastClientOptions.AppId"/> 的副本。
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppWebcastClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppWebcastClientOptions.PlatformPublicKey"/> 的副本。
        /// </summary>
        public string PlatformPublicKey { get; set; } = default!;

        internal Credentials(DouyinMicroAppWebcastClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            AppId = options.AppId;
            AppSecret = options.AppSecret;
            PlatformPublicKey = options.PlatformPublicKey;
        }
    }
}
