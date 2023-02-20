namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /sync_callback_url 接口的请求。</para>
    /// </summary>
    public class ProductApiSyncCallbackUrlRequest : ByteDanceMicroAppProductApiRequest
    {
        /// <summary>
        /// 获取或设置接受通知的 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback_url")]
        [System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string CallbackUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置确认通知方身份唯一标识。</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("developer_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("developer_flag")]
        public string DeveloperFlag { get; set; } = string.Empty;
    }
}
