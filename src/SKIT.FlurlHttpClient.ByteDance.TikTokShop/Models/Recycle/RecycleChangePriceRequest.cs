namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /recycle/changePrice 接口的请求。</para>
    /// </summary>
    public class RecycleChangePriceRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置线索单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clue_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("clue_order_id")]
        public string ClueOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回收价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recycle_price")]
        [System.Text.Json.Serialization.JsonPropertyName("recycle_price")]
        public int? RecyclePrice { get; set; }

        /// <summary>
        /// 获取或设置寄售价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("consignment_price")]
        [System.Text.Json.Serialization.JsonPropertyName("consignment_price")]
        public int? ConsignmentPrice { get; set; }
    }
}
