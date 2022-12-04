namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/item/base 接口的响应。</para>
    /// </summary>
    public class DataExternalItemBaseResponse : DouyinOpenResponse<DataExternalItemBaseResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置最近 30 天评论数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_comment")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_comment")]
                        public int TotalCommentCount { get; set; }

                        /// <summary>
                        /// 获取或设置最近 30 天点赞数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_like")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_like")]
                        public int TotalLikeCount { get; set; }

                        /// <summary>
                        /// 获取或设置最近 30 天播放数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_play")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_play")]
                        public int TotalPlayCount { get; set; }

                        /// <summary>
                        /// 获取或设置最近 30 天分享数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_share")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_share")]
                        public int TotalShareCount { get; set; }

                        /// <summary>
                        /// 获取或设置最近 30 天平均播放时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avg_play_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("avg_play_duration")]
                        public double AveragePlayDuration { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public Types.Result Result { get; set; } = default!;
            }
        }
    }
}
