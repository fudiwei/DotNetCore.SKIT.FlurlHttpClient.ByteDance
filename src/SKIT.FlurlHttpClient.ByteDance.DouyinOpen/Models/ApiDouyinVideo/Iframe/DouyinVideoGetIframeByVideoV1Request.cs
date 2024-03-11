namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/douyin/v1/video/get_iframe_by_video 接口的请求。</para>
    /// </summary>
    public class DouyinVideoGetIframeByVideoV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置视频 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string VideoId { get; set; } = string.Empty;
    }
}
