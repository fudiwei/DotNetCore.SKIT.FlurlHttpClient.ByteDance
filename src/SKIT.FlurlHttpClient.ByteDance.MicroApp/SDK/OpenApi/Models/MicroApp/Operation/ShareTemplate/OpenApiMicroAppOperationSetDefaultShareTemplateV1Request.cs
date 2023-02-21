namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/operation/set_default_share_tpl 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppOperationSetDefaultShareTemplateV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("templateId")]
        [System.Text.Json.Serialization.JsonPropertyName("templateId")]
        public string TemplateId { get; set; } = string.Empty;
    }
}
