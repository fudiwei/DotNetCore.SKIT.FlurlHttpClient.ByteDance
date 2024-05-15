namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/orders/{order_id}/split 接口的响应。</para>
    /// </summary>
    public class FulfillmentSplitOrderResponse : TikTokShopResponse<FulfillmentSplitOrderResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Package
                    {
                        /// <summary>
                        /// 获取或设置包裹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string PackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分组 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("splittable_group_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("splittable_group_id")]
                        public string SplittableGroupId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置包裹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("packages")]
                [System.Text.Json.Serialization.JsonPropertyName("packages")]
                public Types.Package[] PackageList { get; set; } = default!;
            }
        }
    }
}
