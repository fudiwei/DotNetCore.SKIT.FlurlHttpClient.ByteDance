namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity
{
    public class ByteDanceMicroAppAuthEntityClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置字节小程序 API 域名。
        /// <para>默认值：<see cref="ByteDanceMicroAppAuthEntityEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = ByteDanceMicroAppAuthEntityEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置字节小程序 AppId。
        /// </summary>
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置字节小程序 AppSecret。
        /// </summary>
        public string AppSecret { get; set; } = default!;
    }
}
