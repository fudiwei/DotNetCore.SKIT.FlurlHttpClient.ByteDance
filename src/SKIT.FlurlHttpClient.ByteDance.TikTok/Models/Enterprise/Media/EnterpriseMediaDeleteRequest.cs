namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/media/delete 接口的请求。</para>
    /// </summary>
    public class EnterpriseMediaDeleteRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置素材 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = string.Empty;
    }
}
