namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /token/get 接口的响应。</para>
    /// </summary>
    public class AuthGetTokenResponse : TikTokShopResponse<AuthGetTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置接口调用凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("access_token")]
                [System.Text.Json.Serialization.JsonPropertyName("access_token")]
                public string AccessToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置凭证过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("access_token_expire_in")]
                [System.Text.Json.Serialization.JsonPropertyName("access_token_expire_in")]
                public long AccessTokenExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置刷新令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refresh_token")]
                [System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
                public string RefreshToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置刷新令牌过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refresh_token_expire_in")]
                [System.Text.Json.Serialization.JsonPropertyName("refresh_token_expire_in")]
                public long RefreshTokenExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_type")]
                [System.Text.Json.Serialization.JsonPropertyName("user_type")]
                public int UserType { get; set; }

                /// <summary>
                /// 获取或设置卖家名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seller_name")]
                [System.Text.Json.Serialization.JsonPropertyName("seller_name")]
                public string? SellerName { get; set; }

                /// <summary>
                /// 获取或设置卖家所在地。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seller_base_region")]
                [System.Text.Json.Serialization.JsonPropertyName("seller_base_region")]
                public string? SellerBaseRegion { get; set; }

                /// <summary>
                /// 获取或设置已授权的权限列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("granted_permissions")]
                [System.Text.Json.Serialization.JsonPropertyName("granted_permissions")]
                public string[]? GrantedPermissionList { get; set; }
            }
        }
    }
}
