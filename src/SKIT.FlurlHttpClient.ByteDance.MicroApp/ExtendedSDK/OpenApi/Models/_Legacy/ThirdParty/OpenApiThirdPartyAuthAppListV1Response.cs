namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/tp/auth_app_list 接口的响应。</para>
    /// </summary>
    public class OpenApiThirdPartyAuthAppListV1Response : OpenApiLegacyResponseBase
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class AuthApp
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("authAppId")]
                        [System.Text.Json.Serialization.JsonPropertyName("authAppId")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置授权时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("authTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("authTime")]
                        public long AuthTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置授权小程序列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authAppList")]
                [System.Text.Json.Serialization.JsonPropertyName("authAppList")]
                public Types.AuthApp[] AuthAppList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
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
