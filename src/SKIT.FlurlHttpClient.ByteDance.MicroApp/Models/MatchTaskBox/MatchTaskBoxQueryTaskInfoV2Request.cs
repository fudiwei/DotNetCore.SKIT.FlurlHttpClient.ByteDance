namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /match/v2/taskbox/query_task_info/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskBoxQueryTaskInfoV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        [System.Text.Json.Serialization.JsonPropertyName("page_num")]
        public int PageNumber { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置查询参数类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_params_type")]
        [System.Text.Json.Serialization.JsonPropertyName("query_params_type")]
        public int QueryParameterType { get; set; }

        /// <summary>
        /// 获取或设置查询参数内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_params_content")]
        [System.Text.Json.Serialization.JsonPropertyName("query_params_content")]
        public string QueryParameterContent { get; set; } = string.Empty;
    }
}
