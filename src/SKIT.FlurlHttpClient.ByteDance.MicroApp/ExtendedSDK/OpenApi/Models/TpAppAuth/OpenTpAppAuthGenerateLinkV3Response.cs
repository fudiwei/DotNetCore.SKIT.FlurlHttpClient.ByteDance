namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /tpapp/v3/auth/gen_link 接口的响应。</para>
    /// </summary>
    public class OpenTpAppAuthGenerateLinkV3Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置授权链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link")]
                [System.Text.Json.Serialization.JsonPropertyName("link")]
                public string AuthLink { get; set; } = default!;
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
