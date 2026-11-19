namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/trade_order/query/ 接口的响应。</para>
    /// </summary>
    public class MinisTradeOrderQueryResponse : TikTokV2Response<MinisTradeOrderQueryResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置交易订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_order_id")]
                public string? TradeOrderId { get; set; }

                /// <summary>
                /// 获取或设置交易订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_order_status")]
                public string? TradeOrderStatus { get; set; }
            }
        }
    }
}
