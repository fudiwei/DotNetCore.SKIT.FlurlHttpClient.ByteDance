namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/api/upload_resource 接口的请求。</para>
    /// </summary>
    public class ProductApiUploadResourceRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

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
    }
}
