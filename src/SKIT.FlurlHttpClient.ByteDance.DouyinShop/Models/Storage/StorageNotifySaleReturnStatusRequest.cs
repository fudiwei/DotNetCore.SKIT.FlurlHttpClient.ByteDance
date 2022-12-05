namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /storage/notifySaleReturnStatus 接口的请求。</para>
    /// </summary>
    public class StorageNotifySaleReturnStatusRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置物流单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_no")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_no")]
        public string LogisticsNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置务商编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendor")]
        [System.Text.Json.Serialization.JsonPropertyName("vendor")]
        public string VendorCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置业务发生时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("occurrence_time")]
        [System.Text.Json.Serialization.JsonPropertyName("occurrence_time")]
        public long OccurrenceTimestamp { get; set; }

        /// <summary>
        /// 获取或设置原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }
    }
}
