namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/{version}/orders/external_orders 接口的响应。</para>
    /// </summary>
    public class OrderCreateExternalOrderResponse : TikTokShopResponse<OrderCreateExternalOrderResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Error
                    {
                        public static class Types
                        {
                            public class Detail
                            {
                                public static class Types
                                {
                                    public class ExternalOrder
                                    {
                                        /// <summary>
                                        /// 获取或设置外部订单 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                                        public string ExternalOrderId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置来源平台。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("platform")]
                                        [System.Text.Json.Serialization.JsonPropertyName("platform")]
                                        public string Platform { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置订单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                                public string OrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置外部订单信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("external_order")]
                                [System.Text.Json.Serialization.JsonPropertyName("external_order")]
                                public Types.ExternalOrder ExternalOrder { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public int Code { get; set; }

                        /// <summary>
                        /// 获取或设置错误信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("message")]
                        [System.Text.Json.Serialization.JsonPropertyName("message")]
                        public string Message { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置详细信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail")]
                        public Types.Detail Detail { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置错误列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errors")]
                [System.Text.Json.Serialization.JsonPropertyName("errors")]
                public Types.Error[]? ErrorList { get; set; } = default!;
            }
        }
    }
}
