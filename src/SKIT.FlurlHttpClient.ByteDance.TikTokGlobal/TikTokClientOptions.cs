namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    /// <summary>
    /// 一个用于构造 <see cref="TikTokClient"/> 时使用的配置项。
    /// </summary>
    public class TikTokClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置 TikTok API 域名。
        /// <para>默认值：<see cref="TikTokEndpoints.DEFAULT"/></para>
        /// </summary>
        public string? Endpoints { get; set; }

        /// <summary>
        /// 获取或设置 TikTok 应用 Key。
        /// </summary>
        public string ClientKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置 TikTok 应用密钥。
        /// </summary>
        public string ClientSecret { get; set; } = default!;
    }
}
