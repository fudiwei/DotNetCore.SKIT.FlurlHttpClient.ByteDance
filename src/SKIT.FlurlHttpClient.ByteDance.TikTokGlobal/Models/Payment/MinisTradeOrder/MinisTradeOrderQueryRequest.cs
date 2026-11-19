namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/trade_order/query/ 接口的请求。</para>
    /// </summary>
    public class MinisTradeOrderQueryRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置交易订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_order_id")]
        public string? TradeOrderId { get; set; }
    }
}
