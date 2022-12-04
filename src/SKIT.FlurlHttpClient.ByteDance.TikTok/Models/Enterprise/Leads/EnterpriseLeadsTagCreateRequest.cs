namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/leads/tag/create 接口的请求。</para>
    /// </summary>
    public class EnterpriseLeadsTagCreateRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置标签名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_name")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_name")]
        public string TagName { get; set; } = string.Empty;
    }
}
