namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 抖音小程序 API 接口域名。
    /// </summary>
    public static class DouyinMicroAppEndpoints
    {
        /// <summary>
        /// 默认域名。
        /// </summary>
        public const string DEFAULT = "https://developer.toutiao.com/api";

        /// <summary>
        /// 沙盒环境域名。
        /// </summary>
        public const string SANGBOX = "https://open-sandbox.douyin.com/api";
    }

    /// <summary>
    /// 抖音小程序直播小玩法 API 接口域名。
    /// </summary>
    public static class DouyinMicroAppWebcastEndpoints
    {
        /// <summary>
        /// 主域名（默认）。
        /// </summary>
        public const string DEFAULT = "https://webcast.bytedance.com/api";
    }
}
