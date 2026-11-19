namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/subscription/create/ 接口的请求。</para>
    /// </summary>
    public class MinisSubscriptionCreateRequest : TikTokV2Request
    {
        public static class Types
        {
            public class OrderInfo
            {
                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置订单 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_url")]
                [System.Text.Json.Serialization.JsonPropertyName("order_url")]
                public string? OrderUrl { get; set; }

                /// <summary>
                /// 获取或设置订单详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("order_detail")]
                public string? OrderDetail { get; set; }

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_name")]
                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                public string? ProductName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置等级 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tier_id")]
        [System.Text.Json.Serialization.JsonPropertyName("tier_id")]
        public string? TierId { get; set; }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        public Types.OrderInfo? OrderInfo { get; set; }
    }
}
