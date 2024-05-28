namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/create_auth_order/ 接口的请求。</para>
    /// </summary>
    public class TradeAuthDeveloperCreateAuthOrderV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置准入 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admissible_token")]
        [System.Text.Json.Serialization.JsonPropertyName("admissible_token")]
        public string AdmissibleToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开发者信用单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_auth_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_auth_order_no")]
        public string OutAuthOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调通知 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }
    }
}
