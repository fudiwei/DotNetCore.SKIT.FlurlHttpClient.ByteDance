using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /discovery/ent/rank/item/ 接口的响应。</para>
    /// </summary>
    public class DiscoveryEntertainmentRankItemResponse : DouyinOpenResponse<DiscoveryEntertainmentRankItemResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Album
                    {
                        /// <summary>
                        /// 获取或设置猫眼 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("maoyan_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("maoyan_id")]
                        public string? MaoyanId { get; set; }

                        /// <summary>
                        /// 获取或设置 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置片名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置英文片名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name_en")]
                        [System.Text.Json.Serialization.JsonPropertyName("name_en")]
                        public string? EnglishName { get; set; }

                        /// <summary>
                        /// 获取或设置上映日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("release_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("release_date")]
                        public string? ReleaseDateString { get; set; }

                        /// <summary>
                        /// 获取或设置导演列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("directors")]
                        [System.Text.Json.Serialization.JsonPropertyName("directors")]
                        public string[]? DirectorList { get; set; }

                        /// <summary>
                        /// 获取或设置演员列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actors")]
                        [System.Text.Json.Serialization.JsonPropertyName("actors")]
                        public string[]? ActorList { get; set; }

                        /// <summary>
                        /// 获取或设置标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tags")]
                        [System.Text.Json.Serialization.JsonPropertyName("tags")]
                        public string[]? TagList { get; set; }

                        /// <summary>
                        /// 获取或设置地区列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("areas")]
                        [System.Text.Json.Serialization.JsonPropertyName("areas")]
                        public string[]? AreaList { get; set; }

                        /// <summary>
                        /// 获取或设置海报 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poster")]
                        [System.Text.Json.Serialization.JsonPropertyName("poster")]
                        public string? PosterUrl { get; set; }

                        /// <summary>
                        /// 获取或设置讨论度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discussion_hot")]
                        [System.Text.Json.Serialization.JsonPropertyName("discussion_hot")]
                        public int DiscussionHot { get; set; }

                        /// <summary>
                        /// 获取或设置搜索指数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("search_hot")]
                        [System.Text.Json.Serialization.JsonPropertyName("search_hot")]
                        public int SearchHot { get; set; }

                        /// <summary>
                        /// 获取或设置影响力指数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("influence_hot")]
                        [System.Text.Json.Serialization.JsonPropertyName("influence_hot")]
                        public int InfluenceHot { get; set; }

                        /// <summary>
                        /// 获取或设置话题指数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("topic_hot")]
                        [System.Text.Json.Serialization.JsonPropertyName("topic_hot")]
                        public int TopicHot { get; set; }

                        /// <summary>
                        /// 获取或设置热度值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hot")]
                        [System.Text.Json.Serialization.JsonPropertyName("hot")]
                        public decimal HotValue { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置刷新时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("active_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                public DateTimeOffset ActiveTime { get; set; }

                /// <summary>
                /// 获取或设置榜单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Album[] AlbumList { get; set; } = default!;
            }
        }
    }
}
