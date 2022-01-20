namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/activitySearch 接口的响应。</para>
    /// </summary>
    public class BuyinActivitySearchResponse : TikTokShopResponse<BuyinActivitySearchResponse.Types.Data>
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
                        [Newtonsoft.Json.JsonProperty("activity_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                        public long ActivityId { get; set; }

                        /// <summary>
                        /// 获取或设置活动名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activity_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_name")]
                        public string ActivityName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置团长机构名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("institution_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("institution_name")]
                        public string InstitutionName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置活动描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activity_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_desc")]
                        public string ActivityDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置最低商品佣金率（范围：0～100）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_rate")]
                        public int CommissionRate { get; set; }

                        /// <summary>
                        /// 获取或设置佣金率（范围：0～100）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_activity_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_activity_ratio")]
                        public double ActivityRatio { get; set; }

                        /// <summary>
                        /// 获取或设置最低团长服务费率（范围：0～100）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_rate")]
                        public int ServiceRate { get; set; }

                        /// <summary>
                        /// 获取或设置服务费率（范围：0～100）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_rate")]
                        public double ServiceRatio { get; set; }

                        /// <summary>
                        /// 获取或设置预估销售额（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("estimated_single_sale")]
                        [System.Text.Json.Serialization.JsonPropertyName("estimated_single_sale")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int EstimatedSingleSale { get; set; }

                        /// <summary>
                        /// 获取或设置活动开始时间字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apply_start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("apply_start_time")]
                        public string ApplyStartDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置活动结束时间字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apply_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("apply_end_time")]
                        public string ApplyEndDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置推广开始时间字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promote_start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("promote_start_time")]
                        public string PromoteStartDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置推广结束时间字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promote_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("promote_end_time")]
                        public string PromoteEndDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置活动状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activity_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_status")]
                        public int ActivityStatus { get; set; }

                        /// <summary>
                        /// 获取或设置活动状态描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activity_status_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_status_desc")]
                        public string ActivityStatusDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商家类型限制列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_type_limit")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerArrayWithCommaSplitConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_type_limit")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualIntegerArrayWithCommaSplitConverter))]
                        public int[]? LimittedShopTypeList { get; set; }

                        /// <summary>
                        /// 获取或设置商家体验分限制列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_score_limit")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerArrayWithCommaSplitConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_score_limit")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualIntegerArrayWithCommaSplitConverter))]
                        public int[]? LimittedShopScoreList { get; set; }

                        /// <summary>
                        /// 获取或设置招商类目 ID 限制列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("categories_limit")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerArrayWithCommaSplitConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("categories_limit")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualIntegerArrayWithCommaSplitConverter))]
                        public int[]? LimittedCategoryIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置活动列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_list")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_list")]
                public Types.Activity[] ActivityList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
