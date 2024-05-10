namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/activity/create 接口的请求。</para>
    /// </summary>
    public class PromotionCreateActivityRequest : TikTokShopLegacyRequest
    {
        /// <summary>
        /// 获取或设置请求序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_serial_no")]
        [System.Text.Json.Serialization.JsonPropertyName("request_serial_no")]
        public string RequestSerialNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置促销 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_id")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_id")]
        public string PromotionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置促销类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_type")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_type")]
        public int PromotionType { get; set; }

        /// <summary>
        /// 获取或设置活动标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_type")]
        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
        public int ProductType { get; set; }

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
