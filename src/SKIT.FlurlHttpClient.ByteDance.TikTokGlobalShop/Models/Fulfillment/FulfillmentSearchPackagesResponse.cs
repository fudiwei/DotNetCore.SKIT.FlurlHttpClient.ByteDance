namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/search 接口的响应。</para>
    /// </summary>
    public class FulfillmentSearchPackagesResponse : TikTokShopResponse<FulfillmentSearchPackagesResponse.Types.Data>
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
                        [Newtonsoft.Json.JsonProperty("package_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string PackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置包裹状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("package_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("package_status")]
                        public int PackageStatus { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置包裹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_list")]
                [System.Text.Json.Serialization.JsonPropertyName("package_list")]
                public Types.Package[] PackageList { get; set; } = default!;

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
