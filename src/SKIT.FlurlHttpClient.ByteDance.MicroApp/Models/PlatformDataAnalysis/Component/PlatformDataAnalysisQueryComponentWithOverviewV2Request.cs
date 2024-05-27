using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_component_with_overview/ 接口的请求。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryComponentWithOverviewV2Request : DouyinMicroAppRequest
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
        /// 获取或设置组件配置 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("componentId_list")]
        [System.Text.Json.Serialization.JsonPropertyName("componentId_list")]
        public IList<string>? ComponentIdList { get; set; }
    }
}
