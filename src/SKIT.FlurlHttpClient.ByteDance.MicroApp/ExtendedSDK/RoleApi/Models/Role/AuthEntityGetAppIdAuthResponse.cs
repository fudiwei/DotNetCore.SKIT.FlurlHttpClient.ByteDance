namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /get_appid_auth 接口的响应。</para>
    /// </summary>
    public class AuthEntityGetAppIdAuthResponse : DouyinMicroAppRoleApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Material : AuthEntityGetBasicAuthResponse.Types.Material
                    {
                    }

                    public class Qualification : AuthEntityGetBasicAuthResponse.Types.Qualification
                    {
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置认证状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_status")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_status")]
                public int AuthStatus { get; set; }

                /// <summary>
                /// 获取或设置认证失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_reason")]
                public string? AuthFailReason { get; set; }

                /// <summary>
                /// 获取或设置线上生效的授权书信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("online_auth_letter")]
                [System.Text.Json.Serialization.JsonPropertyName("online_auth_letter")]
                public Types.Qualification? OnlineAuthLetterQualification { get; set; }

                /// <summary>
                /// 获取或设置当前审核的的授权书信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_auth_letter")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_auth_letter")]
                public Types.Qualification? AuditAuthLetterQualification { get; set; }

                /// <summary>
                /// 获取或设置权限类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scope")]
                [System.Text.Json.Serialization.JsonPropertyName("scope")]
                public int Scope { get; set; }

                /// <summary>
                /// 获取或设置昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nick")]
                [System.Text.Json.Serialization.JsonPropertyName("nick")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置头像资源路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("icon")]
                [System.Text.Json.Serialization.JsonPropertyName("icon")]
                public string IconPath { get; set; } = default!;

                /// <summary>
                /// 获取或设置描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string Description { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
