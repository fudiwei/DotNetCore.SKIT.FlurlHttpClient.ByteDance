using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/service_provider/sync 接口的请求。</para>
    /// </summary>
    public class POIServiceProviderSyncV2Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class BusinessLicense
            {
                /// <summary>
                /// 获取或设置营业执照外部 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_license_ext_id")]
                [System.Text.Json.Serialization.JsonPropertyName("business_license_ext_id")]
                public string? ExternalId { get; set; }

                /// <summary>
                /// 获取或设置营业执照公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company")]
                [System.Text.Json.Serialization.JsonPropertyName("company")]
                public string? Company { get; set; }

                /// <summary>
                /// 获取或设置营业执照链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }
            }

            public class IndustryLicense
            {
                /// <summary>
                /// 获取或设置行业许可证外部 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_license_ext_id")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_license_ext_id")]
                public string? ExternalId { get; set; }

                /// <summary>
                /// 获取或设置行业许可证链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }
            }

            public class Contact
            {
                /// <summary>
                /// 获取或设置姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("email")]
                [System.Text.Json.Serialization.JsonPropertyName("email")]
                public string? Email { get; set; }

                /// <summary>
                /// 获取或设置电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_number")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                public string? PhoneNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商家营业执照信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_license")]
        [System.Text.Json.Serialization.JsonPropertyName("business_license")]
        public Types.BusinessLicense? BusinessLicense { get; set; }

        /// <summary>
        /// 获取或设置商家行业许可证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_license")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_license")]
        public IList<Types.IndustryLicense>? IndustryLicenseList { get; set; }

        /// <summary>
        /// 获取或设置联系人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification_contact")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification_contact")]
        public Types.Contact? Contact { get; set; }
    }
}
