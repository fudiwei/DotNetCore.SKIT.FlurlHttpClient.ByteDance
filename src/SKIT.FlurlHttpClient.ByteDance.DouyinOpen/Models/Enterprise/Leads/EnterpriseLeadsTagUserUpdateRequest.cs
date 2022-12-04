namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/leads/tag/user/update 接口的请求。</para>
    /// </summary>
    public class EnterpriseLeadsTagUserUpdateRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置标签 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag_id")]
        [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
        public long TagId { get; set; }

        /// <summary>
        /// 获取或设置意向用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string UserOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否是绑定操作。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind")]
        [System.Text.Json.Serialization.JsonPropertyName("bind")]
        public bool IsBinding { get; set; }
    }
}
