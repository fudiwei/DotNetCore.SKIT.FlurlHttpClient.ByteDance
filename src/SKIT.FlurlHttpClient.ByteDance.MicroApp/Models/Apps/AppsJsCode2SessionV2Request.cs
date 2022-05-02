namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v2/jscode2session 接口的请求。</para>
    /// </summary>
    public class AppsJsCode2SessionV2Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置字节小程序的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置字节小程序的 AppSecret。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secret")]
        [System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? AppSecret { get; set; }

        /// <summary>
        /// 获取或设置登录 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 获取或设置匿名登录 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anonymous_code")]
        [System.Text.Json.Serialization.JsonPropertyName("anonymous_code")]
        public string? AnoymousCode { get; set; }
    }
}
