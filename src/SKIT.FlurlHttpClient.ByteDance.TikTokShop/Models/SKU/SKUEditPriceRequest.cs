namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /sku/editPrice 接口的请求。</para>
    /// </summary>
    public class SKUEditPriceRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置 SKU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualLongConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public long SKUId { get; set; }

        /// <summary>
        /// 获取或设置价格（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price")]
        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public int Price { get; set; }
    }
}
