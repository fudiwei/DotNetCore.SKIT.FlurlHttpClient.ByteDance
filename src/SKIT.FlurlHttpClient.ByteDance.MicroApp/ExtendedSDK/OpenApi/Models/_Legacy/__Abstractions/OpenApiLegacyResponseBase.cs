namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    public abstract class OpenApiLegacyResponseBase : DouyinMicroAppOpenApiResponse
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("errno")]
        [System.Text.Json.Serialization.JsonPropertyName("errno")]
        public override int ErrorNumber { get; set; }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public override string? ErrorMessage { get; set; }
    }
}
