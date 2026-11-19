namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/subscription/get_trade_order_info/ 接口的请求。</para>
    /// </summary>
    public class MinisSubscriptionGetTradeOrderInfoRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置交易订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_order_id")]
        public string? TradeOrderId { get; set; }
    }
}
