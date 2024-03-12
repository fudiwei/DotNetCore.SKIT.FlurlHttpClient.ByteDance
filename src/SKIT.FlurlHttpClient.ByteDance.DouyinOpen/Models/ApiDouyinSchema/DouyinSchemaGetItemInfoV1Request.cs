namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/schema/get_item_info/ 接口的请求。</para>
    /// </summary>
    public class DouyinSchemaGetItemInfoV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置视频 ID。与字段 <see cref="VideoId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_id")]
        [System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// 获取或设置视频 ID。与字段 <see cref="ItemId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
        public string? VideoId { get; set; }

        /// <summary>
        /// 获取或设置短链过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_at")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_at")]
        public long ExpireTimestamp { get; set; }
    }
}
