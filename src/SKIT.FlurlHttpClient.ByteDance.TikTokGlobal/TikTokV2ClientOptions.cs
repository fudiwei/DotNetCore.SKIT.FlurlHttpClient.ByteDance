namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    /// <summary>
    /// 一个用于构造 <see cref="TikTokV2Client"/> 时使用的配置项。
    /// </summary>
    public class TikTokV2ClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置 TikTok API 入口点。
        /// <para>默认值：<see cref="TikTokV2Endpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = TikTokV2Endpoints.DEFAULT;

        /// <summary>
        /// 获取或设置 TikTok ClientKey。
        /// </summary>
        public string ClientKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置 TikTok ClientSecret。
        /// </summary>
        public string ClientSecret { get; set; } = default!;
    }
}
