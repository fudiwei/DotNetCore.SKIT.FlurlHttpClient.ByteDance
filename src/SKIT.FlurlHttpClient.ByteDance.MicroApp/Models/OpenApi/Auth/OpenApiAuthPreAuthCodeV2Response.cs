namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/v2/auth/pre_auth_code 接口的响应。</para>
    /// </summary>
    public class OpenApiAuthPreAuthCodeV2Response : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errno")]
        [System.Text.Json.Serialization.JsonPropertyName("errno")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置预授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_auth_code")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_auth_code")]
        public string PreAuthCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置预授权码有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
