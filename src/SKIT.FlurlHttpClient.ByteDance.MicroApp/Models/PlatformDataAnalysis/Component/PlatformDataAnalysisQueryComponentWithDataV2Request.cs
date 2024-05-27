using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_component_with_data/ 接口的请求。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryComponentWithDataV2Request : DouyinMicroAppRequest
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

        /// <summary>
        /// 获取或设置是否查询短视频维度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_query_video")]
        [System.Text.Json.Serialization.JsonPropertyName("is_query_video")]
        public bool IsQueryVideo { get; set; }

        /// <summary>
        /// 获取或设置是否查询直播维度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_query_live")]
        [System.Text.Json.Serialization.JsonPropertyName("is_query_live")]
        public bool IsQueryLive { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_no")]
        [System.Text.Json.Serialization.JsonPropertyName("page_no")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;
    }
}
