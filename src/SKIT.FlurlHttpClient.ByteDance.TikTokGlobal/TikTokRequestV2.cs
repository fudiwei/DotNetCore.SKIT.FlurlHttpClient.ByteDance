namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    /// <summary>
    /// TikTok API v2 请求的基类。
    /// </summary>
    public abstract class TikTokRequestV2 : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置接口调用凭证。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
