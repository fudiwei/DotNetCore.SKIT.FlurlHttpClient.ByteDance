namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /star/author_score_v2 接口的请求。</para>
    /// </summary>
    public class StarAuthorScoreV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DouyinId { get; set; } = string.Empty;
    }
}
