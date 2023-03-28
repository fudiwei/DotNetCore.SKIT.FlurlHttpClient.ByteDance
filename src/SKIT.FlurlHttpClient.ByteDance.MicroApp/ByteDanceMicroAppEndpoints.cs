namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 字节小程序 API 接口域名。
    /// </summary>
    public static class ByteDanceMicroAppEndpoints
    {
        /// <summary>
        /// 小程序 API 域名（默认）。
        /// </summary>
        public const string API_MINIAPP = "https://developer.toutiao.com/api";

        /// <summary>
        /// 小程序 API 沙盒环境域名。
        /// </summary>
        public const string API_MINIAPP_SANDBOX = "https://open-sandbox.douyin.com/api";

        /// <summary>
        /// 小游戏 API 域名。
        /// </summary>
        public const string API_MINIGAME = "https://minigame.zijieapi.com/mgplatform/api";
    }

    /// <summary>
    /// 字节小程序直播小玩法 API 接口域名。
    /// </summary>
    public static class ByteDanceMicroAppWebcastEndpoints
    {
        /// <summary>
        /// 主域名（默认）。
        /// </summary>
        public const string DEFAULT = "https://webcast.bytedance.com/api";
    }
}
