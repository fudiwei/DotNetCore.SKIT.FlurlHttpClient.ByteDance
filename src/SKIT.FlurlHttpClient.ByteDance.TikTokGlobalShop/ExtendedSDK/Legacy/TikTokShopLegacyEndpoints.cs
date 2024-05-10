using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy
{
    /// <summary>
    /// TikTok Shop API 接口域名。
    /// </summary>
    [Obsolete("此类型专为旧版 API 设计，将于 2024-12-31 下线。")]
    public static class TikTokShopLegacyEndpoints
    {
        /// <summary>
        /// 主域名（默认）。
        /// </summary>
        public const string DEFAULT = "https://open-api.tiktokglobalshop.com/api";

        /// <summary>
        /// 沙箱域名。
        /// </summary>
        public const string SANDBOX = "https://open-api-sandbox.tiktokglobalshop.com/api";

        /// <summary>
        /// 美国域名。
        /// </summary>
        public const string REGION_US = "https://open-api.us.tiktokglobalshop.com/api";
    }

    /// <summary>
    /// TikTok Shop Auth API 接口域名。
    /// </summary>
    [Obsolete("此类型专为旧版 API 设计，将于 2024-12-31 下线。")]
    public static class TikTokShopLegacyAuthApiEndpoints
    {
        /// <summary>
        /// 主域名（默认）。
        /// </summary>
        public const string DEFAULT = "https://auth.tiktok-shops.com/api/v2";

        /// <summary>
        /// 沙箱域名。
        /// </summary>
        public const string SANDBOX = "https://auth-sandbox.tiktok-shops.com/api/v2";
    }
}
