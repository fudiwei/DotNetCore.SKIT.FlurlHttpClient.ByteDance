namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/addOrderRemark 接口的请求。</para>
    /// </summary>
    public class OrderAddOrderRemarkRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string Remark { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否加旗标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_add_star")]
        [System.Text.Json.Serialization.JsonPropertyName("is_add_star")]
        public bool? IsAddStar { get; set; }

        /// <summary>
        /// 获取或设置旗标等级（范围：0～5）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("star")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("star")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? Star { get; set; }
    }
}
