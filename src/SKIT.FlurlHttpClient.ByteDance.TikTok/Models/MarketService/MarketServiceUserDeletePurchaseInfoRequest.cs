namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /market/service/user/delete/purchase/info 接口的请求。</para>
    /// </summary>
    public class MarketServiceUserDeletePurchaseInfoRequest : TikTokRequest
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
        /// 获取或设置是否为测试环境。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_test_env")]
        [System.Text.Json.Serialization.JsonPropertyName("is_test_env")]
        public bool IsTestEnvironment { get; set; }
    }
}
