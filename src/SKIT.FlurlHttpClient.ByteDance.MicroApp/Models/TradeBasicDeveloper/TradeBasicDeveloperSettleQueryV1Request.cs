namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_basic/v1/developer/settle_query/ 接口的请求。</para>
    /// </summary>
    public class TradeBasicDeveloperSettleQueryV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置开发者订单号。与字段 <see cref="OrderId"/>、<see cref="OutSettleNumber"/>、<see cref="SettleId"/> 四选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string? OutOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置订单号。与字段 <see cref="OutOrderNumber"/>、<see cref="OutSettleNumber"/>、<see cref="SettleId"/> 四选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置开发者分账单号。与字段 <see cref="OutOrderNumber"/>、<see cref="OrderId"/>、<see cref="SettleId"/> 四选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_settle_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_settle_no")]
        public string? OutSettleNumber { get; set; }

        /// <summary>
        /// 获取或设置分账单号。与字段 <see cref="OutOrderNumber"/>、<see cref="OrderId"/>、<see cref="OutSettleNumber"/> 四选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_id")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_id")]
        public string? SettleId { get; set; }
    }
}
