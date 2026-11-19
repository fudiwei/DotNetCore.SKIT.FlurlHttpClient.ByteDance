namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/tts/review/ 接口的响应。</para>
    /// </summary>
    public class ResearchTTSReviewResponse : TikTokV2Response<ResearchTTSReviewResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Review
                    {
                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                        public string? ProductName { get; set; }

                        /// <summary>
                        /// 获取或设置评论内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("review_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("review_text")]
                        public string? ReviewText { get; set; }

                        /// <summary>
                        /// 获取或设置评论评价。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("review_rating")]
                        [System.Text.Json.Serialization.JsonPropertyName("review_rating")]
                        public string? ReviewRating { get; set; }

                        /// <summary>
                        /// 获取或设置评论点赞数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("review_like_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("review_like_count")]
                        public long ReviewLikeCount { get; set; }

                        /// <summary>
                        /// 获取或设置评论创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置评论列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("review_data")]
                [System.Text.Json.Serialization.JsonPropertyName("review_data")]
                public List<Types.Review>? ReviewList { get; set; }
            }
        }
    }
}
