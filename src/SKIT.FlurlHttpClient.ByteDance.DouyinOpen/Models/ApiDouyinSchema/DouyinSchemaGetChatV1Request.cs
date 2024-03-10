namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/schema/get_chat/ 接口的请求。</para>
    /// </summary>
    public class DouyinSchemaGetChatV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置抖音号。与字段 <see cref="OpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account")]
        [System.Text.Json.Serialization.JsonPropertyName("account")]
        public string? DouyinId { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。与字段 <see cref="DouyinId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置短链过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_at")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_at")]
        public long ExpireTimestamp { get; set; }
    }
}
