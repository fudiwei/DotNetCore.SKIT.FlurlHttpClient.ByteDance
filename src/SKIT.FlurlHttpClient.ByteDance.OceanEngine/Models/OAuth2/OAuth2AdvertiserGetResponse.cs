namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /oauth2/advertiser/get 接口的响应。</para>
    /// </summary>
    public class OAuth2AdvertiserGetResponse : OceanEngineResponse<OAuth2AdvertiserGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Advertiser
                    {
                        /// <summary>
                        /// 获取或设置账号 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
                        public long AdvertiserId { get; set; }

                        /// <summary>
                        /// 获取或设置账号名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser_name")]
                        public string AdvertiserName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置账号角色。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser_role")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser_role")]
                        public int AdvertiserRole { get; set; }

                        /// <summary>
                        /// 获取或设置授权是否有效。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_valid")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_valid")]
                        public bool IsValid { get; set; }

                        /// <summary>
                        /// 获取或设置新版授权账号角色。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_role")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_role")]
                        public string? AccountRole { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Advertiser[] AdvertiserList { get; set; } = default!;
            }
        }
    }
}
