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
        /// 获取或设置小程序的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置资源文件路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_uri")]
        [System.Text.Json.Serialization.JsonPropertyName("resource_uri")]
        public string ResourcePath { get; set; } = string.Empty;
    }
}
