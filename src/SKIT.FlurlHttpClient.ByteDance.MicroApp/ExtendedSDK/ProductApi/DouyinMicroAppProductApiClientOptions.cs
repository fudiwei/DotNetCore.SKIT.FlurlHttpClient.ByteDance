namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi
{
    /// <summary>
    /// 一个用于构造 <see cref="DouyinMicroAppProductApiClient"/> 时使用的配置项。
    /// </summary>
    public class DouyinMicroAppProductApiClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置抖音小程序泛知识课程库 API 入口点。
        /// <para>默认值：<see cref="DouyinMicroAppProductApiEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = DouyinMicroAppProductApiEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置抖音小程序 AppId。
        /// </summary>
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置抖音小程序 AppSecret。
        /// </summary>
        public string AppSecret { get; set; } = default!;
    }
}
