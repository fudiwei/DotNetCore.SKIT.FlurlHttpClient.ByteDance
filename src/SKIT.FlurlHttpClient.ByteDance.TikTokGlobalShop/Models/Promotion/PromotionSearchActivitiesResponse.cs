namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/activity/list 接口的响应。</para>
    /// </summary>
    public class PromotionSearchActivitiesResponse : TikTokShopResponse<PromotionSearchActivitiesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Promotion
                    {
                        /// <summary>
                        /// 获取或设置促销 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string PromotionId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置促销类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_type")]
                        public int PromotionType { get; set; }

                        /// <summary>
                        /// 获取或设置活动标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                        public int ProductType { get; set; }

                        /// <summary>
                        /// 获取或设置活动状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

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
                /// 获取或设置促销列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_list")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_list")]
                public Types.Promotion[] PromotionList { get; set; } = default!;

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
