namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /user/info 接口的响应。</para>
    /// </summary>
    public class UserInfoResponse : TikTokResponse<UserInfoResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResponseData
            {
                public static class Types
                {
                    public class User
                    {
                        /// <summary>
                        /// 获取或设置用户的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户的 UnionId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("union_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("union_id")]
                        public string? UnionId { get; set; }

                        /// <summary>
                        /// 获取或设置用户头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avatar_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
                        public string? AvatarUrl { get; set; }

                        /// <summary>
                        /// 获取或设置用户 100×100 尺寸头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avatar_url_100")]
                        [System.Text.Json.Serialization.JsonPropertyName("avatar_url_100")]
                        public string? Avatar100Url { get; set; }

                        /// <summary>
                        /// 获取或设置用户高清头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avatar_large_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("avatar_large_url")]
                        public string? AvatarLargeUrl { get; set; }

                        /// <summary>
                        /// 获取或设置用户展示名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("display_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("display_name")]
                        public string? DisplayName { get; set; }

                        /// <summary>
                        /// 获取或设置用户个人描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bio_description")]
                        [System.Text.Json.Serialization.JsonPropertyName("bio_description")]
                        public string? BioDescription { get; set; }

                        /// <summary>
                        /// 获取或设置用户个人资料页 DeepLink 地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("profile_deep_link")]
                        [System.Text.Json.Serialization.JsonPropertyName("profile_deep_link")]
                        public string? ProfileDeepLink { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user")]
                [System.Text.Json.Serialization.JsonPropertyName("user")]
                public Types.User User { get; set; } = default!;
            }
        }
    }
}
