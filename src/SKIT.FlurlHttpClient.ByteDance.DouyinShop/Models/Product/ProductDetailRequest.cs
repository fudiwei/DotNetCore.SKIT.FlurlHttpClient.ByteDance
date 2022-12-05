namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/detail 接口的请求。</para>
    /// </summary>
    public class ProductDetailRequest : DouyinShopRequest
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
        /// 获取或设置是否读取草稿数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("show_draft")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("show_draft")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualNullableBooleanConverter))]
        public bool? RequireShowDraft { get; set; }
    }
}
