namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/delete_aweme_video_keyword 接口的请求。</para>
    /// </summary>
    public class AppsCapacityDeleteAwemeVideoKeywordV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置关键词 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_id")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword_id")]
        public string KeywordId { get; set; } = string.Empty;
    }
}
