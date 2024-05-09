using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v2/taskbox/agency_query_video_sum_data/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskboxAgencyQueryVideoSummaryDataV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置视频 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("video_ids")]
        public IList<long> VideoIdList { get; set; } = new List<long>();
    }
}
