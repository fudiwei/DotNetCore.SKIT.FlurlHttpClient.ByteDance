namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast
{
    /// <summary>
    /// 抖音小程序直播小玩法 API 请求的基类。
    /// </summary>
    public abstract class DouyinMicroAppWebcastRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置抖音小程序的 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
