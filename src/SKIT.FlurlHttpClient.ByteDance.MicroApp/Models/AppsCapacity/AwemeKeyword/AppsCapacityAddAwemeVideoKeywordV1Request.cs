namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/capacity/add_aweme_video_keyword/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacityAddAwemeVideoKeywordV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置关键词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword")]
        public string Keyword { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置申请原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }
    }
}
