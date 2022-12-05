namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/hot_video 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardHotVideoResponse : DouyinOpenResponse<DataExternalBillboardHotVideoResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Item
                    {
                        /// <summary>
                        /// 获取或设置视频标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频发布者。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("author")]
                        [System.Text.Json.Serialization.JsonPropertyName("author")]
                        public string Author { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置封面 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_cover")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_cover")]
                        public string CoverUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频分享 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_url")]
                        public string ShareUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置排名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rank")]
                        [System.Text.Json.Serialization.JsonPropertyName("rank")]
                        public int Rank { get; set; }

                        /// <summary>
                        /// 获取或设置播放数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("play_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("play_count")]
                        public int PlayCount { get; set; }

                        /// <summary>
                        /// 获取或设置点赞数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("digg_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("digg_count")]
                        public int DiggCount { get; set; }

                        /// <summary>
                        /// 获取或设置评论数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_count")]
                        public int CommentCount { get; set; }

                        /// <summary>
                        /// 获取或设置热词。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hot_words")]
                        [System.Text.Json.Serialization.JsonPropertyName("hot_words")]
                        public string HotWords { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置热度指数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hot_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("hot_value")]
                        public double HotValue { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置热门视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Item[] List { get; set; } = default!;
            }
        }
    }
}
