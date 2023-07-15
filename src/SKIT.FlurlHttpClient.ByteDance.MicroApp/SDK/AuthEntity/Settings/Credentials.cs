using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="ByteDanceMicroAppAuthEntityClientOptions.AppId"/> 的副本。
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="ByteDanceMicroAppAuthEntityClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; }

        internal Credentials(ByteDanceMicroAppAuthEntityClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            AppId = options.AppId;
            AppSecret = options.AppSecret;
        }
    }
}
