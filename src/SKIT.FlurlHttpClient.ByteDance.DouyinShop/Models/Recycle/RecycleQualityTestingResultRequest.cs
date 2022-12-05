namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /recycle/qualityTestingResult 接口的请求。</para>
    /// </summary>
    public class RecycleQualityTestingResultRequest : DouyinShopRequest
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
        /// 获取或设置是否通过。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_passed")]
        [System.Text.Json.Serialization.JsonPropertyName("is_passed")]
        public bool IsPassed { get; set; }

        /// <summary>
        /// 获取或设置不通过理由类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_reason")]
        public int? FailedReasonType { get; set; }
    }
}
