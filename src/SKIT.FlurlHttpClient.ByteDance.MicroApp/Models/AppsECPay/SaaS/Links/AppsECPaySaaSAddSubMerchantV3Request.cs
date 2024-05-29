namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/ecpay/v3/saas/add_sub_merchant/ 接口的请求。</para>
    /// </summary>
    public class AppsECPaySaaSAddSubMerchantV3Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序第三方平台应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thirdparty_id")]
        [System.Text.Json.Serialization.JsonPropertyName("thirdparty_id")]
        public string ComponentAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_merchant_id")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户角色。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role")]
        [System.Text.Json.Serialization.JsonPropertyName("role")]
        public int? Role { get; set; }

        /// <summary>
        /// 获取或设置 URL 类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_type")]
        [System.Text.Json.Serialization.JsonPropertyName("url_type")]
        public int UrlType { get; set; }

        /// <summary>
        /// 获取或设置支付解决方案类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prod_id")]
        [System.Text.Json.Serialization.JsonPropertyName("prod_id")]
        public int? ProductType { get; set; }
    }
}
