namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    /// <summary>
    /// 一个用于构造 <see cref="DouyinOpenClient"/> 时使用的配置项。
    /// </summary>
    public class DouyinOpenClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置抖音开放平台 API 入口点。
        /// <para>默认值：<see cref="DouyinOpenEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = DouyinOpenEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置抖音开放平台应用 Key。
        /// </summary>
        public string ClientKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置抖音开放平台应用密钥。
        /// </summary>
        public string ClientSecret { get; set; } = default!;

        /// <summary>
        /// 获取或设置抖音开放平台 Webhook 验签秘钥。
        /// </summary>
        public string WebhookSecret { get; set; } = default!;
    }
}
