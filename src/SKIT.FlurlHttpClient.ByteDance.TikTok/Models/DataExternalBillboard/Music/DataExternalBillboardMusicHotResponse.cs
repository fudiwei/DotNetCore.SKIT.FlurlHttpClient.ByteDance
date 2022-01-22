namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/music/hot 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardMusicHotResponse : TikTokResponse<DataExternalBillboardMusicHotResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                public static class Types
                {
                    public class Item
                    {
                        /// <summary>
                        /// 获取或设置歌曲作者。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("author")]
                        [System.Text.Json.Serialization.JsonPropertyName("author")]
                        public string Author { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置歌曲标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置封面 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cover")]
                        [System.Text.Json.Serialization.JsonPropertyName("cover")]
                        public string CoverUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("duration")]
                        public int Duration { get; set; }

                        /// <summary>
                        /// 获取或设置排名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rank")]
                        [System.Text.Json.Serialization.JsonPropertyName("rank")]
                        public int Rank { get; set; }

                        /// <summary>
                        /// 获取或设置音乐分享链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_url")]
                        public string ShareUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置使用量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("use_count")]
                        public int UseCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置榜单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Item[] List { get; set; } = default!;
            }
        }
    }
}
