namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /market/service/user/insert/purchase/info 接口的请求。</para>
    /// </summary>
    public class MarketServiceUserInsertPurchaseInfoRequest : TikTokRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public override string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务规格 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_mode_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_mode_id")]
        public string ServiceModeId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置外部开发者单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务订购时间毫秒级时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("purchase_time")]
        [System.Text.Json.Serialization.JsonPropertyName("purchase_time")]
        public long PurchaseTimeMilliseconds { get; set; }

        /// <summary>
        /// 获取或设置周期类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period_type")]
        [System.Text.Json.Serialization.JsonPropertyName("period_type")]
        public int PeriodType { get; set; }

        /// <summary>
        /// 获取或设置订购时长值（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duration")]
        [System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 获取或设置订购使用次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("usage_times")]
        [System.Text.Json.Serialization.JsonPropertyName("usage_times")]
        public int? UsageTimes { get; set; }

        /// <summary>
        /// 获取或设置是否为测试环境。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_test_env")]
        [System.Text.Json.Serialization.JsonPropertyName("is_test_env")]
        public bool IsTestEnvironment { get; set; }
    }
}
