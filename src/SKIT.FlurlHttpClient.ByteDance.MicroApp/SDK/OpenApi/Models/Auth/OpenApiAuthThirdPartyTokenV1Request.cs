namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/auth/tp/token 接口的请求。</para>
    /// </summary>
    public class OpenApiAuthThirdPartyTokenV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置第三方应用 AppSecret。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAppSecret { get; set; }

        /// <summary>
        /// 获取或设置推送的 Ticket。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentTicket { get; set; } = string.Empty;
    }
}
