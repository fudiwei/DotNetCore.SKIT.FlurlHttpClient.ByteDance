namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/ecom/v1/config/register_ma_app/ 接口的请求。</para>
    /// </summary>
    public class ECommerceConfigRegisterMicroAppV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置电商类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ecom_microapp_type")]
        [System.Text.Json.Serialization.JsonPropertyName("ecom_microapp_type")]
        public int ECommerceType { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback_url")]
        [System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 获取或设置额外信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra")]
        [System.Text.Json.Serialization.JsonPropertyName("extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// 获取或设置预览图 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("preview_photo_url")]
        [System.Text.Json.Serialization.JsonPropertyName("preview_photo_url")]
        public string? PreviewPhotoUrl { get; set; }
    }
}
