namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/orders/{order_id}/packages 接口的响应。</para>
    /// </summary>
    public class FulfillmentUpdateOrderPackagesResponse : TikTokShopResponse<FulfillmentUpdateOrderPackagesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Warning
                    {
                        /// <summary>
                        /// 获取或设置警告信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("message")]
                        [System.Text.Json.Serialization.JsonPropertyName("message")]
                        public string Message { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单行 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_line_item_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("order_line_item_ids")]
                public string[]? OrderLineItemIdList { get; set; }

                /// <summary>
                /// 获取或设置包裹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_id")]
                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string PackageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置警告信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warning")]
                [System.Text.Json.Serialization.JsonPropertyName("warning")]
                public Types.Warning? Warning { get; set; }
            }
        }
    }
}
