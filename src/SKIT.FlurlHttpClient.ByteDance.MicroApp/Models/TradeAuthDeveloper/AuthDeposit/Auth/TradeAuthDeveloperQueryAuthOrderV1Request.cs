namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/query_auth_order/ 接口的请求。</para>
    /// </summary>
    public class TradeAuthDeveloperQueryAuthOrderV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置开发者信用单号。与字段 <see cref="AuthOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_auth_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_auth_order_no")]
        public string? OutAuthOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置信用单 ID。与字段 <see cref="OutAuthOrderNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_order_id")]
        public string? AuthOrderId { get; set; }
    }
}
