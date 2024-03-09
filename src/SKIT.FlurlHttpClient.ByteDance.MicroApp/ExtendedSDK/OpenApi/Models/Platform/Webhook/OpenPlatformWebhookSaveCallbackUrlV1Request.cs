namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /platform/v1/webhook/save_callback_url/ 接口的请求。</para>
    /// </summary>
    public class OpenPlatformWebhookSaveCallbackUrlV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback_url")]
        [System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string CallbackUrl { get; set; } = string.Empty;
    }
}
