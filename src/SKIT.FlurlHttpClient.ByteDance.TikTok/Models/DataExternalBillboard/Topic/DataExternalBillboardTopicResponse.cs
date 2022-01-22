namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/topic 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardTopicResponse : TikTokResponse<DataExternalBillboardTopicResponse.Types.Data>
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
                        /// 获取或设置话题标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

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
