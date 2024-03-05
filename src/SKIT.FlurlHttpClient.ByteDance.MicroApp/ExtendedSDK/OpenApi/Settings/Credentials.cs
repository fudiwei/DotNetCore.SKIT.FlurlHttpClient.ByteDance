using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppOpenApiClientOptions.ComponentAppId"/> 的副本。
        /// </summary>
        public string ComponentAppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppOpenApiClientOptions.ComponentAppSecret"/> 的副本。
        /// </summary>
        public string ComponentAppSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppClientOptions.PushToken"/> 的副本。
        /// </summary>
        public string? PushToken { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppClientOptions.PushEncodingAESKey"/> 的副本。
        /// </summary>
        public string? PushEncodingAESKey { get; set; }

        internal Credentials(DouyinMicroAppOpenApiClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            ComponentAppId = options.ComponentAppId;
            ComponentAppSecret = options.ComponentAppSecret;
            PushToken = options.PushToken;
            PushEncodingAESKey = options.PushEncodingAESKey;
        }
    }
}
