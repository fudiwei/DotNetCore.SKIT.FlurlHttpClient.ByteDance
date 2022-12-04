namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/leads/tag/update 接口的请求。</para>
    /// </summary>
    public class EnterpriseLeadsTagUpdateRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置标签 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_id")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
        public long TagId { get; set; }

        /// <summary>
        /// 获取或设置标签名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_name")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_name")]
        public string? TagName { get; set; }
    }
}
