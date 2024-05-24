namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/ecpay/saas/add_merchant 接口的请求。</para>
    /// </summary>
    public class AppsECPaySaaSAddMerchantRequest : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序第三方平台应用 ID。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thirdparty_component_id")]
        [System.Text.Json.Serialization.JsonPropertyName("thirdparty_component_id")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("component_access_token")]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 URL 类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_type")]
        [System.Text.Json.Serialization.JsonPropertyName("url_type")]
        public int UrlType { get; set; }
    }
}
