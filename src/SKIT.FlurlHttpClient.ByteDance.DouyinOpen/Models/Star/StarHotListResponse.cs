namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /star/hot_list 接口的响应。</para>
    /// </summary>
    public class StarHotListResponse : DouyinOpenResponse<StarHotListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Star
                    {
                        /// <summary>
                        /// 获取或设置抖音号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unique_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("unique_id")]
                        public string DouyinId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nick_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                        public string Nickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置粉丝数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("follower")]
                        [System.Text.Json.Serialization.JsonPropertyName("follower")]
                        public int FansCount { get; set; }

                        /// <summary>
                        /// 获取或设置热榜排名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rank")]
                        [System.Text.Json.Serialization.JsonPropertyName("rank")]
                        public int Rank { get; set; }

                        /// <summary>
                        /// 获取或设置热榜指数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("score")]
                        [System.Text.Json.Serialization.JsonPropertyName("score")]
                        public decimal Score { get; set; }

                        /// <summary>
                        /// 获取或设置标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tags")]
                        [System.Text.Json.Serialization.JsonPropertyName("tags")]
                        public string[] TagList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置达人列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Star[] StarList { get; set; } = default!;

                /// <summary>
                /// 获取或设置达人热榜类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hot_list_type")]
                [System.Text.Json.Serialization.JsonPropertyName("hot_list_type")]
                public int HotListType { get; set; }

                /// <summary>
                /// 获取或设置达人热榜类型说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hot_list_description")]
                [System.Text.Json.Serialization.JsonPropertyName("hot_list_description")]
                public string HotListDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置达人热榜更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hot_list_update_timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("hot_list_update_timestamp")]
                public long UpdateTimestamp { get; set; }
            }
        }
    }
}
