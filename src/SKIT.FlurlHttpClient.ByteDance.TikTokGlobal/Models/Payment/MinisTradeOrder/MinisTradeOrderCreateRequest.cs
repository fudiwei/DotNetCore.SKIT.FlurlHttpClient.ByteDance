namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/trade_order/create/ 接口的请求。</para>
    /// </summary>
    public class MinisTradeOrderCreateRequest : TikTokV2Request
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
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public string? ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_name")]
                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                public string? ProductName { get; set; }

                /// <summary>
                /// 获取或设置数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quantity")]
                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                public int Quantity { get; set; }

                /// <summary>
                /// 获取或设置数量单位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quantity_unit")]
                [System.Text.Json.Serialization.JsonPropertyName("quantity_unit")]
                public string? QuantityUnit { get; set; }

                /// <summary>
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_url")]
                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                public string? ImageUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置代币类型。
        /// <para>默认值："BEANS"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token_type")]
        [System.Text.Json.Serialization.JsonPropertyName("token_type")]
        public string? TokenType { get; set; } = "BEANS";

        /// <summary>
        /// 获取或设置代币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("token_amount")]
        public int TokenAmount { get; set; }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        public Types.OrderInfo? OrderInfo { get; set; }
    }
}
