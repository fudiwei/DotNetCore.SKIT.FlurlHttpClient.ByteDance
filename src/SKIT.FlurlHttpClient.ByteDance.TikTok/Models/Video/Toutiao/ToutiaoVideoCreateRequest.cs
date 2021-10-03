namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /toutiao/video/create 接口的请求。</para>
    /// </summary>
    public class ToutiaoVideoCreateRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置视频 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_id")]
        [System.Text.Json.Serialization.JsonPropertyName("video_id")]
        public string VideoId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public string Title { get; set; } = string.Empty;
    }
}
