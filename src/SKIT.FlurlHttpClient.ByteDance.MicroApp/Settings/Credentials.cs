using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppClientOptions.AppId"/> 的副本。
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppClientOptions.PushToken"/> 的副本。
        /// </summary>
        public string? PushToken { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppClientOptions.PushEncodingAESKey"/> 的副本。
        /// </summary>
        public string? PushEncodingAESKey { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppClientOptions.AppKeyVersion"/> 的副本。
        /// </summary>
        public string? AppKeyVersion { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppClientOptions.AppPrivateKey"/> 的副本。
        /// </summary>
        public string? AppPrivateKey { get; set; }

        /// <summary>
        /// 初始化客户端时 <see cref="DouyinMicroAppClientOptions.ECPaySalt"/> 的副本。
        /// </summary>
        public string? ECPaySalt { get; }

        internal Credentials(DouyinMicroAppClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            AppId = options.AppId;
            AppSecret = options.AppSecret;
            PushToken = options.PushToken;
            PushEncodingAESKey = options.PushEncodingAESKey;
            AppKeyVersion = options.AppKeyVersion;
            AppPrivateKey = options.AppPrivateKey;
            ECPaySalt = options.ECPaySalt;
        }
    }
}
