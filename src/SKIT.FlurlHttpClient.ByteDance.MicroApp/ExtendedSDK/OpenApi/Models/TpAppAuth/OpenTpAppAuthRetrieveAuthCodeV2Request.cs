namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /tpapp/v2/auth/retrieve_auth_code 接口的请求。</para>
    /// </summary>
    public class OpenTpAppAuthRetrieveAuthCodeV2Request : DouyinMicroAppOpenApiRequest
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("authorization_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_appid")]
        public override string? AuthorizerAppId { get; set; }
    }
}
