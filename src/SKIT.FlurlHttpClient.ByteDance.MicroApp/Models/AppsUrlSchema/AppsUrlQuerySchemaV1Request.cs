namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/url/query_schema/ 接口的请求。</para>
    /// </summary>
    public class AppsUrlQuerySchemaV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schema")]
        [System.Text.Json.Serialization.JsonPropertyName("schema")]
        public string UrlSchema { get; set; } = string.Empty;
    }
}
