using System;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="OceanEngineClientOptions.AppId"/> 的副本。
        /// </summary>
        public long AppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="OceanEngineClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; }

        internal Credentials(OceanEngineClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            AppId = options.AppId;
            AppSecret = options.AppSecret;
        }
    }
}
