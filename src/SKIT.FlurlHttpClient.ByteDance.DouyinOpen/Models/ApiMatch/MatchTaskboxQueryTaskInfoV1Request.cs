namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v1/taskbox/query_task_info/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskboxQueryTaskInfoV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

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
