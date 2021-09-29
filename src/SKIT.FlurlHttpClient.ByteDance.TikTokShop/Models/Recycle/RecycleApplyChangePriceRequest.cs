namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /recycle/applyChangePrice 接口的请求。</para>
    /// </summary>
    public class RecycleApplyChangePriceRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置线索单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clue_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("clue_order_id")]
        public string ClueOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置价格（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price")]
        [System.Text.Json.Serialization.JsonPropertyName("price")]
        public int Price { get; set; }
    }
}
