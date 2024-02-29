namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    /// <summary>
    /// TikTok API 请求的基类。
    /// </summary>
    public abstract class TikTokRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置接口调用凭证。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
