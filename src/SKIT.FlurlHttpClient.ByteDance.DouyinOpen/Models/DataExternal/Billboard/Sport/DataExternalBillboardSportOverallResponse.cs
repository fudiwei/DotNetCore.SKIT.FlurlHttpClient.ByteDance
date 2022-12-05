namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/sport/overall 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardSportOverallResponse : DouyinOpenResponse<DataExternalBillboardSportOverallResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Item
                    {
                        public static class Types
                        {
                            public class Video
                            {
                                /// <summary>
                                /// 获取或设置视频标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置视频封面 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_cover")]
                                [System.Text.Json.Serialization.JsonPropertyName("item_cover")]
                                public string CoverUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置视频播放链接。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("share_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("share_url")]
                                public string ShareUrl { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string Nickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avatar")]
                        [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                        public string AvatarUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置排名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rank")]
                        [System.Text.Json.Serialization.JsonPropertyName("rank")]
                        public int Rank { get; set; }

                        /// <summary>
                        /// 获取或设置排名变化。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rank_change")]
                        [System.Text.Json.Serialization.JsonPropertyName("rank_change")]
                        public string? RankChange { get; set; }

                        /// <summary>
                        /// 获取或设置粉丝数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("follower_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("follower_count")]
                        public int FollowerCount { get; set; }

                        /// <summary>
                        /// 获取或设置近一月在榜次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("onbillbaord_times")]
                        [System.Text.Json.Serialization.JsonPropertyName("onbillbaord_times")]
                        public int OnbillbaordTimes { get; set; }

                        /// <summary>
                        /// 获取或设置影响力指数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("effect_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("effect_value")]
                        public double EffectValue { get; set; }

                        /// <summary>
                        /// 获取或设置热度指数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hot_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("hot_value")]
                        public double HotValue { get; set; }

                        /// <summary>
                        /// 获取或设置视频列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_list")]
                        public Types.Video[] VideoList { get; set; } = default!;
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
