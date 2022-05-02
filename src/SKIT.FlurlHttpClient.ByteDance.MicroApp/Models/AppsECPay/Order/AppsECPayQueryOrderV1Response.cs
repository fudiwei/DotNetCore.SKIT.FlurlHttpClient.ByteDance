using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/v1/query_order 接口的响应。</para>
    /// </summary>
    public class AppsECPayQueryOrderV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Payment
            {
                /// <summary>
                /// 获取或设置支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("total_fee")]
                public int TotalFee { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public string OrderStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("way")]
                [System.Text.Json.Serialization.JsonPropertyName("way")]
                public int? PayMethod { get; set; }

                /// <summary>
                /// 获取或设置渠道单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel_no")]
                [System.Text.Json.Serialization.JsonPropertyName("channel_no")]
                public string? ChannelNumber { get; set; }

                /// <summary>
                /// 获取或设置渠道网关号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel_gateway_no")]
                [System.Text.Json.Serialization.JsonPropertyName("channel_gateway_no")]
                public string? ChannelGatewayNumber { get; set; }

                /// <summary>
                /// 获取或设置卖家商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seller_uid")]
                [System.Text.Json.Serialization.JsonPropertyName("seller_uid")]
                public string? SellerMerchantId { get; set; }

                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                public string? ItemId { get; set; }

                /// <summary>
                /// 获取或设置订单支付时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                public DateTimeOffset? PayTime { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_tips")]
        [System.Text.Json.Serialization.JsonPropertyName("err_tips")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置支付信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_info")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_info")]
        public Types.Payment Payment { get; set; } = default!;
    }
}
