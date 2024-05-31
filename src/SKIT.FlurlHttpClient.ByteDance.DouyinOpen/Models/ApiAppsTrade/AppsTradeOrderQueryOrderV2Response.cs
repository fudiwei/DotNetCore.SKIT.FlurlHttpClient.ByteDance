namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/order/query_order 接口的响应。</para>
    /// </summary>
    public class AppsTradeOrderQueryOrderV2Response : DouyinOpenResponse<AppsTradeOrderQueryOrderV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置开发者订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
                public string OutOrderNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("total_fee")]
                public int TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置已退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                public int RefundAmount { get; set; }

                /// <summary>
                /// 获取或设置已分账金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_amount")]
                public int SettleAmount { get; set; }

                /// <summary>
                /// 获取或设置收款商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seller_uid")]
                [System.Text.Json.Serialization.JsonPropertyName("seller_uid")]
                public string? MerchantId { get; set; }

                /// <summary>
                /// 获取或设置支付渠道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_channel")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_channel")]
                public int? PayChannel { get; set; }

                /// <summary>
                /// 获取或设置渠道支付单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel_pay_id")]
                [System.Text.Json.Serialization.JsonPropertyName("channel_pay_id")]
                public string? ChannelPayId { get; set; }

                /// <summary>
                /// 获取或设置支付时间字符串（格式：yyyy-MM-dd HH:mm:ss）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                public string? PayTimeString { get; set; }

                /// <summary>
                /// 获取或设置自定义字段。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cp_extra")]
                [System.Text.Json.Serialization.JsonPropertyName("cp_extra")]
                public string? Extra { get; set; }

                /// <summary>
                /// 获取或设置结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("message")]
                [System.Text.Json.Serialization.JsonPropertyName("message")]
                public string? ResultMessage { get; set; }

                /// <summary>
                /// 获取或设置短视频或直播间 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_id")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringReadOnlyConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string ItemId { get; set; } = default!;

                /// <summary>
                /// 获取或设置调起收银台的支付订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payment_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("payment_order_id")]
                public string PayOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置核销类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_type")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_type")]
                public int DeliveryType { get; set; }
            }
        }
    }
}
