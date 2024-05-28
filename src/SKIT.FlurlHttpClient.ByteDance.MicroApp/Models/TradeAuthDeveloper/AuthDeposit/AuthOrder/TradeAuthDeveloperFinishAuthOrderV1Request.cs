namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/finish_auth_order/ 接口的请求。</para>
    /// </summary>
    public class TradeAuthDeveloperFinishAuthOrderV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置信用单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_order_id")]
        public string AuthOrderId { get; set; } = string.Empty;
    }
}
