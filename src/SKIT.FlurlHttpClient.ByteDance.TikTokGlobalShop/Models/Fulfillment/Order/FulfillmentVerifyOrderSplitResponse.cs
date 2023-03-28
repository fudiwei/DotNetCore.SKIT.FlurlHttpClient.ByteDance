namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/order_split/verify 接口的响应。</para>
    /// </summary>
    public class FulfillmentVerifyOrderSplitResponse : TikTokShopResponse<FulfillmentVerifyOrderSplitResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置验证结果。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify_order_result")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify_order_result")]
                        public bool VerifyOrderResult { get; set; }
                    }

                    public class FailedOrder
                    {
                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fail_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                        public string? FailReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result_list")]
                [System.Text.Json.Serialization.JsonPropertyName("result_list")]
                public Types.Result[] ResultList { get; set; } = default!;

                /// <summary>
                /// 获取或设置处理失败的订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_list")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
                public Types.FailedOrder[] FailedOrderList { get; set; } = default!;
            }
        }
    }
}
