namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [GET] /fulfillment/pre_combine_pkg/list 接口的响应。</para>
    /// </summary>
    public class FulfillmentSearchPreCombinePackagesResponse : TikTokShopLegacyResponse<FulfillmentSearchPreCombinePackagesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class PreCombinePackage
                    {
                        /// <summary>
                        /// 获取或设置预合包 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pre_combine_pkg_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pre_combine_pkg_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string PreCombinePackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id_list")]
                        public string[] OrderIdList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置预合包列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pre_combine_pkg_list")]
                [System.Text.Json.Serialization.JsonPropertyName("pre_combine_pkg_list")]
                public Types.PreCombinePackage[] PreCombinePackageList { get; set; } = default!;

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
