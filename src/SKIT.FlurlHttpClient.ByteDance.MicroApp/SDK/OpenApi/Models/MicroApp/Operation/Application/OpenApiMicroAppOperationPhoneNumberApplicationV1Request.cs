using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/operation/phone_number_application 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppOperationPhoneNumberApplicationV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置申请原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public int ReasonType { get; set; }

        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public int Scene { get; set; }

        /// <summary>
        /// 获取或设置场景描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置场景示例图路径列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("imagePaths")]
        [System.Text.Json.Serialization.JsonPropertyName("imagePaths")]
        public IList<string>? ImagePathList { get; set; }
    }
}
