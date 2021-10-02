namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /oauth/authorize 接口的请求。</para>
    /// </summary>
    public class OAuthAuthorizeRequest : TikTokRequest
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ResponseType { get; set; } = "code";

        /// <summary>
        /// 获取或设置应用授权作用域。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Scope { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置授权成功后的回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string RedirectUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置请求状态。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? State { get; set; }
    }
}
