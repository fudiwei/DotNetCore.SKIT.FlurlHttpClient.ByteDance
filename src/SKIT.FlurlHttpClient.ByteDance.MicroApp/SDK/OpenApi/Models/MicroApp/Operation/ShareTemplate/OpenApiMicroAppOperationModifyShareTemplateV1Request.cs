namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/operation/modify_share_tpl 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppOperationModifyShareTemplateV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("templateId")]
        [System.Text.Json.Serialization.JsonPropertyName("templateId")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分享标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分享文案。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分享图片路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("imagePath")]
        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; } = string.Empty;
    }
}
