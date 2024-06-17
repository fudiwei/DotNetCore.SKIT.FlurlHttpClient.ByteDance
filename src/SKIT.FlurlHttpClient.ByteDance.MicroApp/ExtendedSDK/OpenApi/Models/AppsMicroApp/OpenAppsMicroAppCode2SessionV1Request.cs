namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/microapp/code2session/ 接口的请求。</para>
    /// </summary>
    public class OpenAppsMicroAppCode2SessionV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public override string? AuthorizerAppId { get; set; }

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
