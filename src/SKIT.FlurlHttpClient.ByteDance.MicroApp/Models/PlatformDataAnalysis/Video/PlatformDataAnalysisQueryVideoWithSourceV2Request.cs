using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_video_with_source/ 接口的请求。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryVideoWithSourceV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置宿主名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("host_name")]
        [System.Text.Json.Serialization.JsonPropertyName("host_name")]
        public string? HostName { get; set; }

        /// <summary>
        /// 获取或设置抖音号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_short_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_short_id_list")]
        public IList<string>? AwemeShortIdList { get; set; }
    }
}
