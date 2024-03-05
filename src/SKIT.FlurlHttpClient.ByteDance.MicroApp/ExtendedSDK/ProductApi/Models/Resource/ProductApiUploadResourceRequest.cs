namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /upload_resource 接口的请求。</para>
    /// </summary>
    public class ProductApiUploadResourceRequest : DouyinMicroAppProductApiRequest
    {
        /// <summary>
        /// 获取或设置资源类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_type")]
        [System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        public int ResourceType { get; set; }

        /// <summary>
        /// 获取或设置资源文件 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_url")]
        [System.Text.Json.Serialization.JsonPropertyName("resource_url")]
        public string ResourceUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义回调数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback_data")]
        [System.Text.Json.Serialization.JsonPropertyName("callback_data")]
        public string? CallbackData { get; set; }
    }
}
