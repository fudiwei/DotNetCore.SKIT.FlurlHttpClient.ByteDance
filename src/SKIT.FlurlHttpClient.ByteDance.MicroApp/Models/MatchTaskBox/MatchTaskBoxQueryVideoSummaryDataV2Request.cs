using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v2/taskbox/query_video_sum_data/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskBoxQueryVideoSummaryDataV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置视频 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("video_ids")]
        public IList<string> VideoIdList { get; set; } = new List<string>();
    }
}
