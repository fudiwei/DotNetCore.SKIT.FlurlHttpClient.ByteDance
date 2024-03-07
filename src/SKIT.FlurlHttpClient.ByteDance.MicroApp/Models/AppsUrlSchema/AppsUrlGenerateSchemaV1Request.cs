namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/url/generate_schema/ 接口的请求。</para>
    /// </summary>
    public class AppsUrlGenerateSchemaV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序的 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

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
        /// 获取或设置是否永不失效。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("no_expire")]
        [System.Text.Json.Serialization.JsonPropertyName("no_expire")]
        public bool IsNoExpire { get; set; }

        /// <summary>
        /// 获取或设置失效时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        public long? ExpireTimestamp { get; set; }
    }
}
