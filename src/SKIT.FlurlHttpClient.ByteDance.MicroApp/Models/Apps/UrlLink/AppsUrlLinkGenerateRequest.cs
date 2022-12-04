namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/url_link/generate 接口的请求。</para>
    /// </summary>
    public class AppsUrlLinkGenerateRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ma_app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ma_app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置宿主名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_name")]
        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
        public string AppName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? PagePath { get; set; }

        /// <summary>
        /// 获取或设置页面查询参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query")]
        [System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? QueryString { get; set; }

        /// <summary>
        /// 获取或设置失效时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        public long ExpireTimestamp { get; set; }
    }
}
