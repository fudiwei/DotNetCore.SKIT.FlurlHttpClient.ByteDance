namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/terminate_sign/ 接口的请求。</para>
    /// </summary>
    public class TradeAuthDeveloperTerminateSignV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置签约单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_order_id")]
        public string AuthOrderId { get; set; } = string.Empty;
    }
}
