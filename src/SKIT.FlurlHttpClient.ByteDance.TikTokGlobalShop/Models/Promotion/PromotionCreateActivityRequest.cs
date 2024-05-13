namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/{version}/activities 接口的请求。</para>
    /// </summary>
    public class PromotionCreateActivityRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置活动类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_type")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_type")]
        public string ActivityType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置活动标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_level")]
        [System.Text.Json.Serialization.JsonPropertyName("product_level")]
        public string ProductLevel { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置活动开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置活动结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }
    }
}
