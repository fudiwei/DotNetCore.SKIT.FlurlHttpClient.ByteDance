using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/data_analysis/query_live_room_data 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-02-02 下线。")]
    public class AppsDataAnalysisQueryLiveRoomDataV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class LiveOverviewData
                    {
                        /// <summary>
                        /// 获取或设置累计观看人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cumulative_audience_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("cumulative_audience_count")]
                        public int CumulativeAudienceCount { get; set; }

                        /// <summary>
                        /// 获取或设置最高在线人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("online_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("online_user_count")]
                        public int OnlineUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置人均观看时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("per_capita_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("per_capita_time")]
                        public decimal AudienceTimePerUser { get; set; }

                        /// <summary>
                        /// 获取或设置新增粉丝数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("increased_fans_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("increased_fans_count")]
                        public int IncreasedFansCount { get; set; }

                        /// <summary>
                        /// 获取或设置评论数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_count")]
                        public int CommentCount { get; set; }

                        /// <summary>
                        /// 获取或设置分享次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_count")]
                        public int ShareTimes { get; set; }

                        /// <summary>
                        /// 获取或设置点赞次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("like_times")]
                        [System.Text.Json.Serialization.JsonPropertyName("like_times")]
                        public int LikeTimes { get; set; }
                    }

                    public class LiveData
                    {
                        /// <summary>
                        /// 获取或设置时间字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time")]
                        [System.Text.Json.Serialization.JsonPropertyName("time")]
                        public string TimeString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置累计观看人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cumulative_audience_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("cumulative_audience_count")]
                        public int CumulativeAudienceCount { get; set; }

                        /// <summary>
                        /// 获取或设置评论数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_count")]
                        public int CommentCount { get; set; }

                        /// <summary>
                        /// 获取或设置分享次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_count")]
                        public int ShareTimes { get; set; }

                        /// <summary>
                        /// 获取或设置点赞次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("like_times")]
                        [System.Text.Json.Serialization.JsonPropertyName("like_times")]
                        public int LikeTimes { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置直播总览数据信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_data_overview")]
                [System.Text.Json.Serialization.JsonPropertyName("live_data_overview")]
                public Types.LiveOverviewData LiveOverviewData { get; set; } = default!;

                /// <summary>
                /// 获取或设置直播数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("live_data_list")]
                public Types.LiveData[] LiveDataList { get; set; } = default!;
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
