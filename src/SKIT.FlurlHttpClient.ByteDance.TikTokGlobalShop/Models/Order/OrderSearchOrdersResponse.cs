namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /orders/search 接口的响应。</para>
    /// </summary>
    public class OrderSearchOrdersResponse : TikTokShopResponse<OrderSearchOrdersResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Order
                    {
                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                        public int OrderStatus { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_list")]
                [System.Text.Json.Serialization.JsonPropertyName("order_list")]
                public Types.Order[] OrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置下一页分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
                public string? NextCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("more")]
                [System.Text.Json.Serialization.JsonPropertyName("more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
