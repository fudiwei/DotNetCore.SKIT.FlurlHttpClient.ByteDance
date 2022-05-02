namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 一个用于构造 <see cref="ByteDanceMicroAppClient"/> 时使用的配置项。
    /// </summary>
    public class ByteDanceMicroAppClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置字节小程序 API 域名。
        /// <para>默认值：<see cref="ByteDanceMicroAppEndpoints.API_MINIAPP"/></para>
        /// </summary>
        public string Endpoints { get; set; } = ByteDanceMicroAppEndpoints.API_MINIAPP;

        /// <summary>
        /// 获取或设置字节小程序 AppId。
        /// </summary>
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置字节小程序 AppSecret。
        /// </summary>
        public string AppSecret { get; set; } = default!;

        /// <summary>
        /// 获取或设置头条服务器推送的 EncodingAESKey。
        /// </summary>
        public string? PushEncodingAESKey { get; set; }

        /// <summary>
        /// 获取或设置头条服务器推送的 Token。
        /// </summary>
        public string? PushToken { get; set; }

        /// <summary>
        /// 获取或设置用于担保支付请求签名的密钥。
        /// </summary>
        public string? ECPaySalt { get; set; }
    }
}
