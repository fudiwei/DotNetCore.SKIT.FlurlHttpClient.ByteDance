namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /hotsearch/trending/sentences 接口的响应。</para>
    /// </summary>
    public class HotSearchTrendingSentencesResponse : TikTokResponse<HotSearchTrendingSentencesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                public static class Types
                {
                    public class TrendingSentence
                    {
                        /// <summary>
                        /// 获取或设置上升词。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sentence")]
                        [System.Text.Json.Serialization.JsonPropertyName("sentence")]
                        public string Sentence { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置热度等级。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hot_level")]
                        [System.Text.Json.Serialization.JsonPropertyName("hot_level")]
                        public int HotLevel { get; set; }

                        /// <summary>
                        /// 获取或设置标签。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("label")]
                        [System.Text.Json.Serialization.JsonPropertyName("label")]
                        public int Label { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置上升词列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.TrendingSentence[] TrendingSentenceList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                public long? PageCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
