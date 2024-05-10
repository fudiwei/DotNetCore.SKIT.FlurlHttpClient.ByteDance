using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy
{
    /// <summary>
    /// 一个用于构造 <see cref="TikTokShopLegacyClient"/> 时使用的配置项。
    /// </summary>
    [Obsolete("此类型专为旧版 API 设计，将于 2024-12-31 下线。")]
    public class TikTokShopLegacyClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置 TikTok API 入口点。
        /// <para>默认值：<see cref="TikTokShopLegacyEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = TikTokShopLegacyEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置 TikTok Auth API 入口点。
        /// <para>默认值：<see cref="TikTokShopLegacyAuthApiEndpoints.DEFAULT"/></para>
        /// </summary>
        public string EndpointForAuthAPI { get; set; } = TikTokShopLegacyAuthApiEndpoints.DEFAULT;

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
