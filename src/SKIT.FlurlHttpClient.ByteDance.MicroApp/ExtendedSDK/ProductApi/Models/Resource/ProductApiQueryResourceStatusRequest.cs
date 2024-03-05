namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_resource_status 接口的请求。</para>
    /// </summary>
    public class ProductApiQueryResourceStatusRequest : DouyinMicroAppProductApiRequest
    {
        /// <summary>
        /// 获取或设置资源文件路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_uri")]
        [System.Text.Json.Serialization.JsonPropertyName("resource_uri")]
        public string ResourcePath { get; set; } = string.Empty;
    }
}
