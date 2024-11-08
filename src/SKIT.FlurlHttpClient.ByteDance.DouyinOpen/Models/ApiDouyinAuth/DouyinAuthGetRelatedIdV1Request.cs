namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/auth/get_related_id/ 接口的请求。</para>
    /// </summary>
    public class DouyinAuthGetRelatedIdV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;
    }
}
