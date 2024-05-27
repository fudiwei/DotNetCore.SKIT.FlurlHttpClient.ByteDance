using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_short_live_id_with_awemeid/ 接口的请求。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryShortLiveIdWithAwemeIdV2Request : DouyinMicroAppRequest
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
        /// 获取或设置查询数据的挂载类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_bind_type")]
        [System.Text.Json.Serialization.JsonPropertyName("query_bind_type")]
        public int QueryBindType { get; set; }

        /// <summary>
        /// 获取或设置查询数据的列表类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_data_type")]
        [System.Text.Json.Serialization.JsonPropertyName("query_data_type")]
        public int? QueryDataType { get; set; }

        /// <summary>
        /// 获取或设置抖音号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_short_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_short_id_list")]
        public IList<string> AwemeShortIdList { get; set; } = new List<string>();
    }
}
