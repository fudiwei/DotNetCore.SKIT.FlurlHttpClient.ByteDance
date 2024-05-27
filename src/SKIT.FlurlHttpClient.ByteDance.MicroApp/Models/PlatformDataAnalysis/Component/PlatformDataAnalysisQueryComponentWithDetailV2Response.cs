namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_component_with_detail/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryComponentWithDetailV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class VideoData
                    {
                        public static class Types
                        {
                            public class VideoData
                            {
                                public static class Types
                                {
                                    public class AnchorInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置抖音号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("AwemeShortID")]
                                        [System.Text.Json.Serialization.JsonPropertyName("AwemeShortID")]
                                        public string AwemeShortId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置账号类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("AccountType")]
                                        [System.Text.Json.Serialization.JsonPropertyName("AccountType")]
                                        public int AccountType { get; set; }

                                        /// <summary>
                                        /// 获取或设置昵称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Nickname")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Nickname")]
                                        public string Nickname { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置头像 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("Avat")]
                                        [System.Text.Json.Serialization.JsonPropertyName("Avat")]
                                        public string AvatarUrl { get; set; } = default!;
                                    }

                                    public class Statistics : PlatformDataAnalysisQueryComponentWithSourceV2Response.Types.Data.Types.ComponentData.Types.Statistics
                                    {
                                        /// <summary>
                                        /// 获取或设置留资组件 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ComponentId")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ComponentId")]
                                        public string ComponentId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置留资组件名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ComponentName")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ComponentName")]
                                        public string ComponentName { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置视频 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemId")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemId")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string ItemId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置视频标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemTitle")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemTitle")]
                                public string ItemTitle { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置视频封面 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemCover")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemCover")]
                                public string ItemCoverUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置视频播放 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemAddr")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemAddr")]
                                public string ItemPlayerUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置视频时长（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemDuration")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemDuration")]
                                public int ItemDuration { get; set; }

                                /// <summary>
                                /// 获取或设置视频创建时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemCreateTime")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemCreateTime")]
                                public long ItemCreateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置视频播放次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemVv")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemVv")]
                                public int ItemVV { get; set; }

                                /// <summary>
                                /// 获取或设置作者信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ShortInfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("ShortInfo")]
                                public Types.AnchorInfo AnchorInfo { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置统计数据。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Data")]
                                [System.Text.Json.Serialization.JsonPropertyName("Data")]
                                public Types.Statistics Statistics { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置短视频留资数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("DataList")]
                        [System.Text.Json.Serialization.JsonPropertyName("DataList")]
                        public Types.VideoData[] VideoDataList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置总数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Total")]
                        [System.Text.Json.Serialization.JsonPropertyName("Total")]
                        public int TotalCount { get; set; }
                    }

                    public class LiveData
                    {
                        public static class Types
                        {
                            public class LiveData
                            {
                                public static class Types
                                {
                                    public class AnchorInfo : VideoData.Types.VideoData.Types.AnchorInfo
                                    {
                                    }

                                    public class Statistics : VideoData.Types.VideoData.Types.Statistics
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置直播间 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("RoomId")]
                                [System.Text.Json.Serialization.JsonPropertyName("RoomId")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string LiveRoomId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置直播时长（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("RoomDuration")]
                                [System.Text.Json.Serialization.JsonPropertyName("RoomDuration")]
                                public int LiveRoomDuration { get; set; }

                                /// <summary>
                                /// 获取或设置直播创建时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("RoomCreateTime")]
                                [System.Text.Json.Serialization.JsonPropertyName("RoomCreateTime")]
                                public long LiveRoomCreateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置视频播放次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ItemVv")]
                                [System.Text.Json.Serialization.JsonPropertyName("ItemVv")]
                                public int ItemVV { get; set; }

                                /// <summary>
                                /// 获取或设置主播信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ShortInfo")]
                                [System.Text.Json.Serialization.JsonPropertyName("ShortInfo")]
                                public Types.AnchorInfo AnchorInfo { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置统计数据。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("Data")]
                                [System.Text.Json.Serialization.JsonPropertyName("Data")]
                                public Types.Statistics Statistics { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置直播留资数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("DataList")]
                        [System.Text.Json.Serialization.JsonPropertyName("DataList")]
                        public Types.LiveData[] LiveDataList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置总数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("Total")]
                        [System.Text.Json.Serialization.JsonPropertyName("Total")]
                        public int TotalCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置短视频数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("VideoData")]
                [System.Text.Json.Serialization.JsonPropertyName("VideoData")]
                public Types.VideoData? VideoData { get; set; }

                /// <summary>
                /// 获取或设置直播数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("LiveData")]
                [System.Text.Json.Serialization.JsonPropertyName("LiveData")]
                public Types.LiveData? LiveData { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
