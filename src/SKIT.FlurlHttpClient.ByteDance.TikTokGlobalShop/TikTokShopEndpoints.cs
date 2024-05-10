namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    /// <summary>
    /// TikTok Shop API 接口域名。
    /// </summary>
    public static class TikTokShopEndpoints
    {
        /// <summary>
        /// 主域名（默认）。
        /// </summary>
        public const string DEFAULT = "https://open-api.tiktokglobalshop.com";

        /// <summary>
        /// 沙箱域名。
        /// </summary>
        public const string SANDBOX = "https://open-api-sandbox.tiktokglobalshop.com";
    }

    /// <summary>
    /// TikTok Shop Auth API 接口域名。
    /// </summary>
    public static class TikTokShopAuthApiEndpoints
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
