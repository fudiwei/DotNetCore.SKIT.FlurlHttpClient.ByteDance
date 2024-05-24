namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/url_link/query_info 接口的请求。</para>
    /// </summary>
    public class AppsUrlLinkQueryInfoV1Request : DouyinMicroAppRequest
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
        [Newtonsoft.Json.JsonProperty("url_link")]
        [System.Text.Json.Serialization.JsonPropertyName("url_link")]
        public string UrlLink { get; set; } = string.Empty;
    }
}
