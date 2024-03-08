namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /tpapp/v2/auth/get_auth_token 接口的响应。</para>
    /// </summary>
    public class OpenApiTpAppAuthGetAuthTokenV2Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Permission
                    {
                        /// <summary>
                        /// 获取或设置权限 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public int Id { get; set; }

                        /// <summary>
                        /// 获取或设置权限分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category")]
                        [System.Text.Json.Serialization.JsonPropertyName("category")]
                        public string Category { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置权限描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string Description { get; set; } = default!;
                    }

                    public class ShareData
                    {
                        /// <summary>
                        /// 获取或设置服务商的分账比例上限（范围：0～30）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_ratio")]
                        public int? ShareRatio { get; set; }

                        /// <summary>
                        /// 获取或设置服务商的分账金额上限（范围：0～50）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_amount")]
                        public int? ShareAmount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置授权方 AccessToken。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorizer_access_token")]
                [System.Text.Json.Serialization.JsonPropertyName("authorizer_access_token")]
                public string AuthorizerAccessToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置授权方 RefreshToken。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorizer_refresh_token")]
                [System.Text.Json.Serialization.JsonPropertyName("authorizer_refresh_token")]
                public string? AuthorizerRefreshToken { get; set; }

                /// <summary>
                /// 获取或设置授权方 AccessToken 有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
                public int ExpiresIn { get; set; }

                /// <summary>
                /// 获取或设置授权方 RefreshToken 有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refresh_expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("refresh_expires_in")]
                public int RefreshTokenExpiresIn { get; set; }

                /// <summary>
                /// 获取或设置授权方小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorizer_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("authorizer_appid")]
                public string? AuthorizerAppId { get; set; }

                /// <summary>
                /// 获取或设置授权权限列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorize_permission")]
                [System.Text.Json.Serialization.JsonPropertyName("authorize_permission")]
                public Types.Permission[]? PermissionList { get; set; }
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
