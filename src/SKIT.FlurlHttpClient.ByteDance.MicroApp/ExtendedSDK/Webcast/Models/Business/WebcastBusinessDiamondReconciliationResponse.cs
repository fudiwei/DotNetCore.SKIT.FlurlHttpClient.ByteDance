namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /business/diamond/reconciliation 接口的响应。</para>
    /// </summary>
    public class WebcastBusinessDiamondReconciliationResponse : DouyinMicroAppWebcastResponse
    {
        public static class Types
        {
            public class Order
            {
                /// <summary>
                /// 获取或设置直播间 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("room_id")]
                [System.Text.Json.Serialization.JsonPropertyName("room_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                public string? RoomId { get; set; }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public int OrderStatus { get; set; }

                /// <summary>
                /// 获取或设置付费点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_tag")]
                public string? PayTag { get; set; }

                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置抖币数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("diamonds")]
                [System.Text.Json.Serialization.JsonPropertyName("diamonds")]
                public int Diamonds { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.ISO8601DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.ISO8601DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public List<Types.Order>? OrderList { get; set; }

        /// <summary>
        /// 获取或设置数据总量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int TotalCount { get; set; }
    }
}
