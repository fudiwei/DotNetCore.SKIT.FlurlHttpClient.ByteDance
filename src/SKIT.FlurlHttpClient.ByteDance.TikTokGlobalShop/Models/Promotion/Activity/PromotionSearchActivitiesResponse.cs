namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/{version}/activities/search 接口的响应。</para>
    /// </summary>
    public class PromotionSearchActivitiesResponse : TikTokShopResponse<PromotionSearchActivitiesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Activity
                    {
                        /// <summary>
                        /// 获取或设置活动 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public virtual string ActivityId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置活动标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置活动状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

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

                        /// <summary>
                        /// 获取或设置活动类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activity_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_type")]
                        public string ActivityType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_level")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_level")]
                        public string ProductLevel { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置活动开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                        public long BeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置活动结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long EndTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置活动列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activities")]
                [System.Text.Json.Serialization.JsonPropertyName("activities")]
                public Types.Activity[] ActivityList { get; set; } = default!;

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
