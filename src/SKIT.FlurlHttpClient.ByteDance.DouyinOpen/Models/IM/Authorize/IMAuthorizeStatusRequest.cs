namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /im/authorize/status/ 接口的请求。</para>
    /// </summary>
    public class IMAuthorizeStatusRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 C 端应用 ClientKey。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? CClientKey { get; set; }

        /// <summary>
        /// 获取或设置 C 端用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("c_open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("c_open_id")]
        public string COpenId { get; set; } = string.Empty;
    }
}
