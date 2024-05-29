using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/ecpay/saas/query_merchant_status 接口的响应。</para>
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
        /// 获取或设置抖音信息主体渠道进件状态信息字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_status_info")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_status_info")]
        public IDictionary<string, Types.MerchantStatusInfo>? MerchantStatusInfoMap { get; set; }

        /// <summary>
        /// 获取或设置光合信号主体渠道进件状态信息字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_merchant_status_info")]
        [System.Text.Json.Serialization.JsonPropertyName("new_merchant_status_info")]
        public IDictionary<string, Types.MerchantStatusInfo>? NewMerchantStatusInfoMap { get; set; }

        /// <summary>
        /// 获取或设置担保支付企业版渠道进件状态信息字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_status_info")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_status_info")]
        public IDictionary<string, Types.MerchantStatusInfo>? PayStatusInfoMap { get; set; }
    }
}
