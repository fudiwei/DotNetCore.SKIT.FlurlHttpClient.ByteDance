namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /hotsearch/videos/ 接口的请求。</para>
    /// </summary>
    public class HotSearchVideosRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置热点词。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string HotSentence { get; set; } = string.Empty;
    }
}
