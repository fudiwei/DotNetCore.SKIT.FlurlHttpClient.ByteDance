namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v1/item/get_base/ 接口的响应。</para>
    /// </summary>
    public class AppsItemGetBaseV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置平均播放时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avg_play_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("avg_play_duration")]
                        public decimal AveragePlayDuration { get; set; }

                        /// <summary>
                        /// 获取或设置播放数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_play")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_play")]
                        public long TotalPlayCount { get; set; }

                        /// <summary>
                        /// 获取或设置评论数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_comment")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_comment")]
                        public long TotalCommentCount { get; set; }

                        /// <summary>
                        /// 获取或设置点赞数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_like")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_like")]
                        public long TotalLikeCount { get; set; }

                        /// <summary>
                        /// 获取或设置分享数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_share")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_share")]
                        public long TotalShareCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置返回结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public Types.Result Result { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
