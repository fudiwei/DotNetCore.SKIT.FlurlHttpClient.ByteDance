namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/auth/retrieve 接口的请求。</para>
    /// </summary>
    public class OpenApiAuthRetrieveV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("component_appid")]
        public override string? ComponentAppId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("component_access_token")]
        public override string? ComponentAccessToken { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_appid")]
        public override string? AuthorizerAppId { get; set; }
    }
}
