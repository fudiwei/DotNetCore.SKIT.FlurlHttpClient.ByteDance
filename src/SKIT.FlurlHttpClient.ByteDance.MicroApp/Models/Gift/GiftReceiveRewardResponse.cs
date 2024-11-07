namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/gift/receive_reward 接口的响应。</para>
    /// </summary>
    public class GiftReceiveRewardResponse : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class GiftInfo
            {
                public static class Types
                {
                    public class Property
                    {
                        /// <summary>
                        /// 获取或设置道具 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("prop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("prop_id")]
                        public string PropId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图标 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("icon")]
                        [System.Text.Json.Serialization.JsonPropertyName("icon")]
                        public string IconUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置道具名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置道具数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置礼包 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gift_id")]
                [System.Text.Json.Serialization.JsonPropertyName("gift_id")]
                public string GiftId { get; set; } = default!;

                /// <summary>
                /// 获取或设置礼包有效开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gift_effective_start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("gift_effective_start_time")]
                public long GiftEffectiveStartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置礼包有效结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gift_effective_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("gift_effective_end_time")]
                public long GiftEffectiveEndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置图标 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("icon_url")]
                [System.Text.Json.Serialization.JsonPropertyName("icon_url")]
                public string IconUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置礼包名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置玩法类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("play_type")]
                [System.Text.Json.Serialization.JsonPropertyName("play_type")]
                public int PlayType { get; set; }

                /// <summary>
                /// 获取或设置关联道具列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prop_list")]
                [System.Text.Json.Serialization.JsonPropertyName("prop_list")]
                public Types.Property[]? PropertyList { get; set; }

                /// <summary>
                /// 获取或设置用户领奖说明列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_receive_guide")]
                [System.Text.Json.Serialization.JsonPropertyName("user_receive_guide")]
                public string[]? UserReceiveGuideList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置操作结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gift_info")]
        [System.Text.Json.Serialization.JsonPropertyName("gift_info")]
        public Types.GiftInfo GiftInfo { get; set; } = default!;
    }
}
