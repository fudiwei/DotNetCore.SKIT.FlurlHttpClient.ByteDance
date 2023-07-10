using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityGetBindListResponse : ByteDanceMicroAppAuthEntityResponse
    {
        public static class Types
        {
            public class BindInfo
            {
                /// <summary>
                /// 小程序appid
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = string.Empty;

                /// <summary>
                /// 角色id
                /// </summary>
                [Newtonsoft.Json.JsonProperty("role_id")]
                [System.Text.Json.Serialization.JsonPropertyName("role_id")]
                public string RoleId { get; set; } = string.Empty;

                /// <summary>
                /// 1:个人(泛知识行业为老师),2:自营机构,3:服务商
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_role")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_role")]
                public int IndustryRole { get; set; }

                /// <summary>
                /// 1000:泛知识
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_code")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
                public long IndustryCode { get; set; }

            }
        }
        /// <summary>
        /// 小程序绑定的所有角色
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_info_list")]
        public List<Types.BindInfo>? BindInfoList { get; set; }
    }
}
