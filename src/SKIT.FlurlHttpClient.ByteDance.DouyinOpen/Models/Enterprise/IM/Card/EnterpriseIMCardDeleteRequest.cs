namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/im/card/delete 接口的请求。</para>
    /// </summary>
    public class EnterpriseIMCardDeleteRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置卡片 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string CardId { get; set; } = string.Empty;
    }
}
