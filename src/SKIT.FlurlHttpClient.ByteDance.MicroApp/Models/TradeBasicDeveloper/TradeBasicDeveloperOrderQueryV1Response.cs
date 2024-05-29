namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_basic/v1/developer/order_query/ 接口的响应。</para>
    /// </summary>
    public class TradeBasicDeveloperOrderQueryV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ItemOrder
                    {
                        /// <summary>
                        /// 获取或设置商品单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                        public string ItemOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public string SKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_order_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_order_amount")]
                        public int Amount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;

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
                [Newtonsoft.Json.JsonProperty("pay_status")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                public int TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置订单优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
                public int DiscountAmount { get; set; }

                /// <summary>
                /// 获取或设置交易时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_time")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_time")]
                public long TradeTimeMilliseconds { get; set; }

                /// <summary>
                /// 获取或设置商品单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_order_list")]
                [System.Text.Json.Serialization.JsonPropertyName("item_order_list")]
                public Types.ItemOrder[] ItemOrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置收款商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_uid")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_uid")]
                public string? MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付渠道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_channel")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_channel")]
                public int? PayChannel { get; set; } = default!;

                /// <summary>
                /// 获取或设置渠道支付单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel_pay_id")]
                [System.Text.Json.Serialization.JsonPropertyName("channel_pay_id")]
                public string? ChannelPayId { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                public long? PayTimeMilliseconds { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
