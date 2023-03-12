namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    /// <summary>
    /// 一个用于构造 <see cref="TikTokShopClient"/> 时使用的配置项。
    /// </summary>
    public class TikTokShopClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置 TikTok API 入口点。
        /// <para>默认值：<see cref="TikTokShopEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = TikTokShopEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置 TikTok Auth API 入口点。
        /// <para>默认值：<see cref="TikTokShopAuthApiEndpoints.DEFAULT"/></para>
        /// </summary>
        public string EndpointForAuthAPI { get; set; } = TikTokShopAuthApiEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置 TikTok Shop AppKey。
        /// </summary>
        public string AppKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置 TikTok Shop AppSecret。
        /// </summary>
        public string AppSecret { get; set; } = default!;
    }
}
