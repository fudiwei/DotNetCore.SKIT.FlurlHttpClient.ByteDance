using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_deal_data_with_conversion/ 接口的请求。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryDealDataWithConversionV2Request : DouyinMicroAppRequest
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
        /// 获取或设置流量来源渠道列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scenes_list")]
        [System.Text.Json.Serialization.JsonPropertyName("scenes_list")]
        public IList<string>? SceneList { get; set; }
    }
}
