namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 一个用于构造 <see cref="DouyinMicroAppClient"/> 时使用的配置项。
    /// </summary>
    public class DouyinMicroAppClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置抖音小程序 API 入口点。
        /// <para>默认值：<see cref="DouyinMicroAppEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = DouyinMicroAppEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置抖音小程序旧版 API 入口点。
        /// <para>默认值：<see cref="DouyinMicroAppEndpoints.LEGACY_DEFAULT"/></para>
        /// </summary>
        public string EndpointForLegacy { get; set; } = DouyinMicroAppEndpoints.LEGACY_DEFAULT;

        /// <summary>
        /// 获取或设置抖音小程序 AppId。
        /// </summary>
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置抖音小程序 AppSecret。
        /// </summary>
        public string AppSecret { get; set; } = default!;

        /// <summary>
        /// 获取或设置抖音服务器推送的 Token。
        /// </summary>
        public string? PushToken { get; set; }

        /// <summary>
        /// 获取或设置抖音服务器推送的 EncodingAESKey。
        /// </summary>
        public string? PushEncodingAESKey { get; set; }

        /// <summary>
        /// 获取或设置用于担保支付请求签名的密钥。
        /// </summary>
        public string? ECPaySalt { get; set; }
    }
}
