namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /market/service/user/remaintimes/decr 接口的请求。</para>
    /// </summary>
    public class MarketServiceUserRemainTimesDecreaseRequest : DouyinOpenRequest
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
        /// 获取或设置订单外部单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置扣减次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// 获取或设置是否为测试环境。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_test_env")]
        [System.Text.Json.Serialization.JsonPropertyName("is_test_env")]
        public bool IsTestEnvironment { get; set; }
    }
}
