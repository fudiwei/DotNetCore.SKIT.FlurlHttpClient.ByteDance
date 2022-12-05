namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/editBuyerLimit 接口的请求。</para>
    /// </summary>
    public class ProductEditBuyerLimitRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualLongConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置每笔订单最多限购件数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maximum_per_order")]
        [System.Text.Json.Serialization.JsonPropertyName("maximum_per_order")]
        public int? MaximumPerOrder { get; set; }

        /// <summary>
        /// 获取或设置每笔订单最少购买件数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minimum_per_order")]
        [System.Text.Json.Serialization.JsonPropertyName("minimum_per_order")]
        public int? MinimumPerOrder { get; set; }

        /// <summary>
        /// 获取或设置每个用户累计限购件数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit_per_buyer")]
        [System.Text.Json.Serialization.JsonPropertyName("limit_per_buyer")]
        public int? LimitPerBuyer { get; set; }
    }
}
