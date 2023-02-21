namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/operation/video_application 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppOperationVideoApplicationV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置申请原因以及挂载内容介绍。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intro")]
        [System.Text.Json.Serialization.JsonPropertyName("intro")]
        public string Introduction { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置挂载锚点文案示例。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anchorText")]
        [System.Text.Json.Serialization.JsonPropertyName("anchorText")]
        public string AnchorText { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序落地页截图路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("imagePath")]
        [System.Text.Json.Serialization.JsonPropertyName("imagePath")]
        public string ImagePath { get; set; } = string.Empty;
    }
}
