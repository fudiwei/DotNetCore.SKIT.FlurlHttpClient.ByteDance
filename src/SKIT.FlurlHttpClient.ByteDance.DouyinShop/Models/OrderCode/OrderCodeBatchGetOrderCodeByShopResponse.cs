namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /orderCode/batchGetOrderCodeByShop 接口的响应。</para>
    /// </summary>
    public class OrderCodeBatchGetOrderCodeByShopResponse : DouyinShopResponse<OrderCodeBatchGetOrderCodeByShopResponse.Types.Data>
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
                        /// 获取或设置订单码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_code")]
                        public string? OrderCode { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单码结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("batch_data")]
                [System.Text.Json.Serialization.JsonPropertyName("batch_data")]
                public Types.Result[] ResultList { get; set; } = default!;

                /// <summary>
                /// 获取或设置送检方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_type")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_type")]
                public int DeliveryType { get; set; }

                /// <summary>
                /// 获取或设置出仓方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ship_type")]
                [System.Text.Json.Serialization.JsonPropertyName("ship_type")]
                public int ShipType { get; set; }
            }
        }
    }
}
