namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/prop 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardPropResponse : TikTokResponse<DataExternalBillboardPropResponse.Types.Data>
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
                        /// 获取或设置道具名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

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
                        /// 获取或设置展现量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("show_cnt")]
                        public int ShowCount { get; set; }

                        /// <summary>
                        /// 获取或设置开拍量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shoot_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("shoot_cnt")]
                        public int ShootCount { get; set; }

                        /// <summary>
                        /// 获取或设置日投稿量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("daily_issue_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("daily_issue_cnt")]
                        public int DailyIssueCount { get; set; }

                        /// <summary>
                        /// 获取或设置日投稿占比字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("daily_issue_percent")]
                        [System.Text.Json.Serialization.JsonPropertyName("daily_issue_percent")]
                        public string DailyIssuePercantString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置日收藏数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("daily_collection_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("daily_collection_cnt")]
                        public int DailyCollectCount { get; set; }

                        /// <summary>
                        /// 获取或设置日播放数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("daily_play_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("daily_play_cnt")]
                        public int DailyPlayCount { get; set; }

                        /// <summary>
                        /// 获取或设置影响力指数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("effect_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("effect_value")]
                        public double EffectValue { get; set; }
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
