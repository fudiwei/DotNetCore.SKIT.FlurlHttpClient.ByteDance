namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/operation/add_share_tpl 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppOperationAddShareTemplateV1Request : DouyinMicroAppOpenApiRequest
    {
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
