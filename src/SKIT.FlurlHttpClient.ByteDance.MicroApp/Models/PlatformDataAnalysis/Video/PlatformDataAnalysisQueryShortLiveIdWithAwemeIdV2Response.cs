using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_short_live_id_with_awemeid/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryShortLiveIdWithAwemeIdV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class OverviewData
                    {
                        /// <summary>
                        /// 获取或设置播放视频数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_watched_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_watched_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ItemWatchedCount { get; set; }

                        /// <summary>
                        /// 获取或设置视频投稿数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_contribute_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_contribute_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ItemContributeCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置总览信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("over_view_data")]
                [System.Text.Json.Serialization.JsonPropertyName("over_view_data")]
                public Types.OverviewData OverviewData { get; set; } = default!;

                /// <summary>
                /// 获取或设置抖音号发布的短视频 ID 列表字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_data")]
                [System.Text.Json.Serialization.JsonPropertyName("item_data")]
                public IDictionary<string, string[]>? ItemIdListMap { get; set; }

                /// <summary>
                /// 获取或设置抖音号发布的直播间 ID 列表字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_data")]
                [System.Text.Json.Serialization.JsonPropertyName("live_data")]
                public IDictionary<string, string[]>? LiveRoomIdListMap { get; set; }
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
