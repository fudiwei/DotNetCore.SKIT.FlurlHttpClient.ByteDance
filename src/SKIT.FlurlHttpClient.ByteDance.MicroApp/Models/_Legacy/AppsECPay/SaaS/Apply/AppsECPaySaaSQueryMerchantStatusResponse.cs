using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/saas/query_merchant_status 接口的响应。</para>
    /// </summary>
    public class AppsECPaySaaSQueryMerchantStatusResponse : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class MerchantStatusInfo
            {
                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_id")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
                public string? MerchantId { get; set; }

                /// <summary>
                /// 获取或设置法人验证页面 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_validation_url")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_validation_url")]
                public string? LegalPersonValidationUrl { get; set; }

                /// <summary>
                /// 获取或设置法人签名页面 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_sign_url")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_sign_url")]
                public string? LegalPersonSignUrl { get; set; }

                /// <summary>
                /// 获取或设置审核拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reject_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                public string? RejectReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信支付渠道进件状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx")]
        [System.Text.Json.Serialization.JsonPropertyName("wx")]
        public int WechatpayStatus { get; set; }

        /// <summary>
        /// 获取或设置支付宝支付渠道进件状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alipay")]
        [System.Text.Json.Serialization.JsonPropertyName("alipay")]
        public int AlipayStatus { get; set; }

        /// <summary>
        /// 获取或设置合众支付渠道进件状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hz")]
        [System.Text.Json.Serialization.JsonPropertyName("hz")]
        public int UlpayStatus { get; set; }

        /// <summary>
        /// 获取或设置易宝支付渠道进件状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yeepay")]
        [System.Text.Json.Serialization.JsonPropertyName("yeepay")]
        public int YeepayStatus { get; set; }

        /// <summary>
        /// 获取或设置渠道状态信息字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_status_info")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_status_info")]
        public IDictionary<string, Types.MerchantStatusInfo>? MerchantStatusInfoMap { get; set; }
    }
}
