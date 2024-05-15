namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fulfillment/{version}/combinable_packages/search 接口的响应。</para>
    /// </summary>
    public class FulfillmentSearchCombinablePackagesResponse : TikTokShopResponse<FulfillmentSearchCombinablePackagesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CombinablePackage
                    {
                        /// <summary>
                        /// 获取或设置可合并的包裹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string CombinablePackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_ids")]
                        public string[] OrderIdList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置可合并的包裹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("combinable_packages")]
                [System.Text.Json.Serialization.JsonPropertyName("combinable_packages")]
                public Types.CombinablePackage[] CombinablePackageList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置下一页分页令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_page_token")]
                [System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
                public string? NextPageToken { get; set; }
            }
        }
    }
}
