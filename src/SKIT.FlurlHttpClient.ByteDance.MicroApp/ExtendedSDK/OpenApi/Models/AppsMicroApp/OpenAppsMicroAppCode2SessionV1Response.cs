namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/microapp/code2session/ 接口的响应。</para>
    /// </summary>
    public class OpenAppsMicroAppCode2SessionV1Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置会话密钥。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("session_key")]
                [System.Text.Json.Serialization.JsonPropertyName("session_key")]
                public string? SessionKey { get; set; }

                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置匿名用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("anonymous_open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("anonymous_open_id")]
                public string? AnonymousOpenId { get; set; }

                /// <summary>
                /// 获取或设置用户的 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("union_id")]
                [System.Text.Json.Serialization.JsonPropertyName("union_id")]
                public string? UnionId { get; set; }
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
