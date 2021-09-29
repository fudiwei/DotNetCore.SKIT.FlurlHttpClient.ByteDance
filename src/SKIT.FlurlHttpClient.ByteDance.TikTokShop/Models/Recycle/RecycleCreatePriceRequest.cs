namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /recycle/createPrice 接口的请求。</para>
    /// </summary>
    public class RecycleCreatePriceRequest : TikTokShopRequest
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

        /// <summary>
        /// 获取或设置是否同意。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_agree")]
        [System.Text.Json.Serialization.JsonPropertyName("is_agree")]
        public bool IsAgreed { get; set; }

        /// <summary>
        /// 获取或设置拒绝理由类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refuse_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("refuse_reason")]
        public int? RefuseReasonType { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置地址 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_id")]
        [System.Text.Json.Serialization.JsonPropertyName("address_id")]
        public int? AddressId { get; set; }
    }
}
