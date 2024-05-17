using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/privacy_setting/add/ 接口的请求。</para>
    /// </summary>
    public class AppsPrivacySettingAddV1Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class PrivacyItem
            {
                /// <summary>
                /// 获取或设置隐私条例 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int Id { get; set; }

                /// <summary>
                /// 获取或设置隐私条例描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_desc")]
                public string ApplyDescription { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置是否需要收集用户隐私。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_privacy_config")]
        [System.Text.Json.Serialization.JsonPropertyName("is_privacy_config")]
        public bool IsPrivacyConfig { get; set; }

        /// <summary>
        /// 获取或设置联系方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_way")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_way")]
        public int? ContactWay { get; set; }

        /// <summary>
        /// 获取或设置邮箱。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 获取或设置座机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("land_line")]
        [System.Text.Json.Serialization.JsonPropertyName("land_line")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        [System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? MobileNumber { get; set; }

        /// <summary>
        /// 获取或设置隐私项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("privacy_item_list")]
        [System.Text.Json.Serialization.JsonPropertyName("privacy_item_list")]
        public IList<Types.PrivacyItem> PrivacyItemList { get; set; } = new List<Types.PrivacyItem>();
    }
}
