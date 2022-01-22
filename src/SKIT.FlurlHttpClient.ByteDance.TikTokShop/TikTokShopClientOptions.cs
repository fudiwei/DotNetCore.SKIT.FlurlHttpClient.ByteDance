namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
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
        /// 获取或设置抖店开放平台 API 域名。
        /// <para>默认值：<see cref="TikTokShopEndpoints.DEFAULT"/></para>
        /// </summary>
        public string? Endpoints { get; set; }

        /// <summary>
        /// 获取或设置抖店开放平台应用 Key。
        /// </summary>
        public string AppKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置抖店开放平台应用密钥。
        /// </summary>
        public string AppSecret { get; set; } = default!;

        /// <summary>
        /// 获取或设置抖店开放平台 API 签名算法。
        /// <para>默认值：<see cref="Constants.SignAlgorithms.HMAC_SHA256"/></para>
        /// </summary>
        public string SignAlgorithm { get; set; } = Constants.SignAlgorithms.HMAC_SHA256;
    }
}
