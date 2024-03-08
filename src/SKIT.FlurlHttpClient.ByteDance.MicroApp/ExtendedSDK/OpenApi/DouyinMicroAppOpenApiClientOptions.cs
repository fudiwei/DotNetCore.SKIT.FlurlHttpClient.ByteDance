namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    /// <summary>
    /// 一个用于构造 <see cref="DouyinMicroAppOpenApiClient"/> 时使用的配置项。
    /// </summary>
    public class DouyinMicroAppOpenApiClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置抖音小程序服务商平台 API 入口点。
        /// <para>默认值：<see cref="DouyinMicroAppOpenApiEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = DouyinMicroAppOpenApiEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置抖音小程序服务商平台旧版 API 入口点。
        /// <para>默认值：<see cref="DouyinMicroAppOpenApiEndpoints.LEGACY_DEFAULT"/></para>
        /// </summary>
        public string EndpointForLegacy { get; set; } = DouyinMicroAppOpenApiEndpoints.LEGACY_DEFAULT;

        /// <summary>
        /// 获取或设置抖音小程序服务商 AppId。
        /// </summary>
        public string ComponentAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置抖音小程序服务商 AppSecret。
        /// </summary>
        public string ComponentAppSecret { get; set; } = default!;

        /// <summary>
        /// 获取或设置头条服务器推送的 Token。
        /// </summary>
        public string? PushToken { get; set; }

        /// <summary>
        /// 获取或设置头条服务器推送的 EncodingAESKey。
        /// </summary>
        public string? PushEncodingAESKey { get; set; }
    }
}
