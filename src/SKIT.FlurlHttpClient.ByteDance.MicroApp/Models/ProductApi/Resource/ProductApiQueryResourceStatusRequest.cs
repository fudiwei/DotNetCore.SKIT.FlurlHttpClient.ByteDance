namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/api/query_resource_status 接口的请求。</para>
    /// </summary>
    public class ProductApiQueryResourceStatusRequest : ByteDanceMicroAppRequest
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
        /// 获取或设置资源文件 URI。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_uri")]
        [System.Text.Json.Serialization.JsonPropertyName("resource_uri")]
        public string ResourceUri { get; set; } = string.Empty;
    }
}
