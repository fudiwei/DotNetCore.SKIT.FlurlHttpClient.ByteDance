namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /tpapp/v2/auth/retrieve_auth_code 接口的响应。</para>
    /// </summary>
    public class OpenTpAppAuthRetrieveAuthCodeV2Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置授权码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorization_code")]
                [System.Text.Json.Serialization.JsonPropertyName("authorization_code")]
                public string AuthorizationCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置授权码有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
                public int ExpiresIn { get; set; }
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
