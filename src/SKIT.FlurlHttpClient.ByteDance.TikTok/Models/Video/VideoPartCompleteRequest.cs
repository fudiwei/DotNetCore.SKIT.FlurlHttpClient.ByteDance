namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/part/complete 接口的请求。</para>
    /// </summary>
    public class VideoPartCompleteRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置上传 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string UploadId { get; set; } = string.Empty;
    }
}
